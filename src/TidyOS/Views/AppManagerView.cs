using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TidyOS.Properties; // for Resources.PredefinedApps
using Windows.Foundation;
using Windows.Management.Deployment;

namespace TidyOS.Views
{
    public partial class AppManagerView : UserControl
    {
        // Stores app name to full package name mapping
        private readonly Dictionary<string, string> appDirectory = new Dictionary<string, string>();

        // Holds all app names for filtering
        private readonly List<string> allPackages = new List<string>();

        // Keeps track of successfully/failed uninstalled apps
        private readonly List<string> uninstallSuccessList = new List<string>();

        private readonly List<string> uninstallFailedList = new List<string>();

        public AppManagerView(NavigationManager navigationManager)
        {
            InitializeComponent();
            LoadApps();
            InitializeUI();
        }

        // Set up the form controls
        private void InitializeUI()
        {
            btnRefresh.Text = "\uE72C"; // Refresh icon
        }

        // Loads apps and filters them against predefined list
        private void LoadApps()
        {
            Task.Run(async () =>
            {
                await RetrieveApps(true);
                Invoke(new MethodInvoker(FilterAppsByPredefined));
            });
        }

        // Retrieves installed apps using PackageManager API
        private async Task RetrieveApps(bool reset)
        {
            if (reset)
            {  // Clear UI elements on the UI thread
                Invoke(new MethodInvoker(() =>
                {
                    checkedListBoxApps.Items.Clear();
                }));

                appDirectory.Clear();
                allPackages.Clear();
            }

            var packageManager = new PackageManager();
            // Run package lookup on a background thread to avoid UI freezing
            var packages = await Task.Run(() => packageManager.FindPackagesForUserWithPackageTypes(string.Empty, PackageTypes.Main));

            foreach (var package in packages)
            {
                string appName = package.Id.Name;
                string fullName = package.Id.FullName;
                // Avoid duplicates
                if (!appDirectory.ContainsKey(appName))
                {  
                    // Update internal tracking
                    appDirectory[appName] = fullName;
                    allPackages.Add(appName);

                    // Invoke to update UI on the main thread
                    Invoke(new MethodInvoker(() => checkedListBoxApps.Items.Add(appName)));
                }
            }
        }

        // Triggered when the Remove button is clicked
        private async void btnRemove_Click(object sender, EventArgs e)
        {
            Enabled = false;
            uninstallSuccessList.Clear();
            uninstallFailedList.Clear();

            //nothing selected?
            if (checkedListBoxApps.CheckedItems.Count == 0)
            {
                MessageBox.Show("You haven't selected anything!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Enabled = true;
                return;
            }

            // Confirm uninstall of selected apps
            var selectedApps = string.Join(Environment.NewLine, checkedListBoxApps.CheckedItems.Cast<string>());
            if (MessageBox.Show($"Are you sure you want to uninstall the following apps?\n\n{selectedApps}", "Confirm uninstall", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                Enabled = true;
                return;
            }

            try
            {
                // Uninstall selected apps
                foreach (string packageName in checkedListBoxApps.CheckedItems)
                    await UninstallApp(packageName);

                // Refresh the app list and update UI
                await RetrieveApps(true);
                Invoke(new MethodInvoker(DisplayUninstallResults)); // Show results
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during uninstallation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true; // Re-enable controls
            }
        }

        // Uninstalls an app by its package name
        private async Task UninstallApp(string packageName)
        {
            string packageFullName;
            if (!appDirectory.TryGetValue(packageName, out packageFullName)) return;

            try
            {
                var packageManager = new PackageManager();
                var deploymentOperation = packageManager.RemovePackageAsync(packageFullName);

                var resetEvent = new ManualResetEvent(false);
                deploymentOperation.Completed = (op, status) => resetEvent.Set();
                await Task.Run(() => resetEvent.WaitOne());

                if (deploymentOperation.Status == AsyncStatus.Completed)
                {
                    uninstallSuccessList.Add(packageFullName);
                    Logger.Log("Successfully uninstalled: " + packageFullName);
                }
                else
                {
                    uninstallFailedList.Add(packageFullName);
                    Logger.Log("Failed to uninstall: " + packageFullName + " - Error: " + deploymentOperation.ErrorCode);
                }
            }
            catch (Exception ex)
            {
                uninstallFailedList.Add(packageFullName);
                Logger.Log("Exception while uninstalling " + packageFullName + ": " + ex.Message);
            }

            appDirectory.Remove(packageName);
        }

        // Displays summary after uninstall process completes
        private void DisplayUninstallResults()
        {
            string message = "App uninstall finished!\n\nOf the " + (uninstallSuccessList.Count + uninstallFailedList.Count) + " total app(s), " + uninstallSuccessList.Count + " were uninstalled.\n\n";

            if (uninstallSuccessList.Count > 0)
                message += "Successfully uninstalled:\n" + string.Join("\n", uninstallSuccessList);

            if (uninstallFailedList.Count > 0)
                message += "\nFailed to uninstall:\n" + string.Join("\n", uninstallFailedList);

            MessageBox.Show(message, "TidyOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Filters the app list using predefined package names from resources
        private void FilterAppsByPredefined()
        {
            // Get the predefined apps from the resource
            string predefined = Resources.PredefinedApps;
            if (string.IsNullOrWhiteSpace(predefined)) return;

            // Split the predefined string into individual app names, trimmed of any leading/trailing whitespace
            string[] predefinedApps = predefined.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(app => app.Trim())
                                                .ToArray();

            // Update the filter text with the predefined apps (comma-separated)
            textFilter.Text = string.Join(", ", predefinedApps);
            // Filter the app list based on the predefined apps
            FilterAppsBySearch(predefinedApps);
        }

        // Filters the app list based on the search string (now works with predefined app names)
        private void FilterAppsBySearch(string[] searchTerms = null)
        {
            // Use the text from the filter if no predefined apps are provided
            if (searchTerms == null)
            {
                searchTerms = textFilter.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(term => term.Trim())
                                             .ToArray();
            }
            checkedListBoxApps.Items.Clear();

            // Add apps that match the search term
            foreach (string appName in allPackages)
            {
                // Check if the app name or full name matches any of the predefined apps
                if (searchTerms.Any(term => appName.ToLower().Contains(term.ToLower())))
                {
                    checkedListBoxApps.Items.Add(appName);
                }
            }
        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            FilterAppsBySearch();
        }

        // Opens the online feed with known bloatware app names
        private void btnAppsFeed_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/builtbybel/TidyOS/blob/main/bloatware_feed.txt") { UseShellExecute = true });
            MessageBox.Show(
                "The Bloatware Feed is now open. Copy the app names from the list and paste them into the text field above. The app will then search for matches.",
                "Bloatware Feed Instructions",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Reloads the app list
        private void btnShowAllInstalled_Click(object sender, EventArgs e)
        {
            textFilter.Text = string.Empty;
            checkedListBoxApps.Items.Clear();

            foreach (var appName in allPackages)
            {
                checkedListBoxApps.Items.Add(appName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FilterAppsByPredefined();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool shouldCheck = checkedListBoxApps.CheckedItems.Count < checkedListBoxApps.Items.Count;

            for (int i = 0; i < checkedListBoxApps.Items.Count; i++)
            {
                checkedListBoxApps.SetItemChecked(i, shouldCheck);
            }

            btnSelect.Text = shouldCheck ? "Unselect All" : "Select All";
        }
    }
}