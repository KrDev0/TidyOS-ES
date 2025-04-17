using System;
using System.Windows.Forms;
using TidyOS.Views;

namespace TidyOS
{
    public static class NavigationHandler
    {
        // Cached views to prevent re-instantiation
        private static ExperienceView _experienceView;
        private static AppManagerView _appManagerView;
        private static PluginsView _pluginsView;
        private static AboutView _aboutView;

        /// <summary>
        /// Initializes navigation buttons and binds click events to view switching.
        /// Views are created lazily upon first access.
        /// Buttons are disabled when the default view (ExperienceView) is shown.
        /// </summary>
        /// <param name="btnExperience">Button to show Experience view</param>
        /// <param name="btnApps">Button to show App Manager view</param>
        /// <param name="btnPlugins">Button to show Plugins view</param>
        /// <param name="btnBack">Button to go back to the previous view</param>
        /// <param name="btnAbout">Button to show About view</param>
        /// <param name="navigationManager">The navigation manager instance</param>
        public static void InitializeNavigation(
            Button btnExperience,
            Button btnApps,
            Button btnPlugins,
            Button btnAbout,
            Button btnBack,
            Label lblHeader,
            NavigationManager navigationManager)
        {
            if (btnExperience == null || btnApps == null || btnPlugins == null || btnBack == null || btnAbout == null || lblHeader == null || navigationManager == null)
                return;

            // Navigation button event handlers
            btnExperience.Click += (s, e) =>
            {
                if (_experienceView == null)
                    _experienceView = new ExperienceView();

                lblHeader.Text = "Customizing";
                btnExperience.Enabled = false;   // Disable btnExperience if ExperienceView is active
                navigationManager.SwitchView(_experienceView);
            };

            btnApps.Click += (s, e) =>
            {
                if (_appManagerView == null)
                    _appManagerView = new AppManagerView(navigationManager);

                lblHeader.Text = "Debloating";
                btnExperience.Enabled = true;
                navigationManager.SwitchView(_appManagerView);
            };

            btnPlugins.Click += (s, e) =>
            {
                if (_pluginsView == null)
                    _pluginsView = new PluginsView(navigationManager);

                lblHeader.Text = "Scripting";
                btnExperience.Enabled = true;
                navigationManager.SwitchView(_pluginsView);
            };

            btnAbout.Click += (s, e) =>
            {
                if (_aboutView == null)
                    _aboutView = new AboutView();

                lblHeader.Text = "Settings";
                btnExperience.Enabled = true;
                navigationManager.SwitchView(_aboutView);
            };

            // Back button event handler
            btnBack.Click += (s, e) =>
            {
                btnExperience.Enabled = true;
                navigationManager.GoBack();

                if (navigationManager.CurrentView is ExperienceView)
                    lblHeader.Text = "Customizing";
                else if (navigationManager.CurrentView is AppManagerView)
                    lblHeader.Text = "Debloating";
                else if (navigationManager.CurrentView is PluginsView)
                    lblHeader.Text = "Scripting";
                else if (navigationManager.CurrentView is AboutView)
                    lblHeader.Text = "Settings";
            };
        }

        /// <summary>
        /// Loads and shows the default view when the form is first shown.
        /// </summary>
        /// <param name="navigationManager">The navigation manager instance</param>
        public static void LoadDefaultView(NavigationManager navigationManager, Button btnExperience, Label lblHeader)
        {
            if (_experienceView == null)
                _experienceView = new ExperienceView();

            lblHeader.Text = "TidyOS"; // Default header text
            btnExperience.Enabled = false;             // Disable btnExperience when ExperienceView is loaded
            navigationManager.SwitchView(_experienceView);
        }
    }
}
