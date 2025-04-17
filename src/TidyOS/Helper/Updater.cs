using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using TidyOS;

namespace Updater
{
    public static class Utils
    {
        // Check for app updates
        public static bool CheckForAppUpdates()
        {
            if (!IsInternetAvailable())
            {
                MessageBox.Show("No internet connection. Update check failed.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                string versionInfoUrl = "https://raw.githubusercontent.com/builtbybel/TidyOS/main/src/TidyOS/Properties/AssemblyInfo.cs";
                string assemblyInfo = new WebClient().DownloadString(versionInfoUrl);

                string latestVersion = assemblyInfo
                    .Split('\n')
                    .FirstOrDefault(line => line.Contains("[assembly: AssemblyFileVersion"))?
                    .Split('"')[1]; // Extract version string

                if (latestVersion == Program.GetAppVersion())
                {
                    MessageBox.Show("No new updates available.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    string downloadUrl = "https://github.com/builtbybel/TidyOS/releases";

                    if (MessageBox.Show($"App version {latestVersion} is available.\nOpen the download page?",
                                        "App Update Available",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(downloadUrl);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to check for updates. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Check Internet connectivity
        private static bool IsInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}