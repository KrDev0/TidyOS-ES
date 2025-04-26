using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TidyOS
{
    public partial class MainForm : Form
    {
        private NavigationManager _navigationManager;

        public MainForm()
        {
            InitializeComponent();
            // Create navigation manager with target content panel
            _navigationManager = new NavigationManager(panelContent);

            // Initialize navigation buttons and handlers
            NavigationHandler.InitializeNavigation(
                btnExperience,
                btnApps,
                btnPlugins,
                btnAbout,
                btnBack,
                lblHeader,
                _navigationManager);

            // Hook into Load event to defer default view loading
            this.Load += MainForm_Load;

            InitializeUI();
        }

        /// <summary>
        /// Handles the form Load event to load the default view.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            NavigationHandler.LoadDefaultView(_navigationManager, btnExperience, lblHeader);
        }

        private void InitializeUI()
        {
            btnBack.Text = "\uE72B";
            this.Size = new Size(600, 700);
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://github.com/builtbybel/TidyOS") { UseShellExecute = true });

        }
    }
}