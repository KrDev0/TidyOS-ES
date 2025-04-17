using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TidyOS.Views
{
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            lblAppVersion.Text = $"Version: {Program.GetAppVersion()}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Updater.Utils.CheckForAppUpdates();
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/builtbybel/TidyOS");
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            try
            {
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string logPath = Path.Combine(exePath, "app.log");

                if (File.Exists(logPath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = logPath,
                        UseShellExecute = true // Let Windows pick the default app
                    });
                }
                else
                {
                    MessageBox.Show("Looks like no logs have been generated yet. Run the app first to create some logs.",
                        "No Log File Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Whoops! Something went wrong while trying to open the log file:\n\n{ex.Message}",
                    "Oops, Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}