using Settings.Ads;
using Settings.AI;
using Settings.Gaming;
using Settings.Personalization;
using Settings.Privacy;
using Settings.System;
using System;
using System.Collections.Generic;
using System.Linq;
using TidyOS;

namespace Views
{
    public class FeatureCatalog
    {
        private List<FeatureBase> features;

        public FeatureCatalog()
        {
            InitializeFeatures();
        }

        private void InitializeFeatures()
        {
            features = new List<FeatureBase>
            {
                // Ads
                new FileExplorerAds(),
                new FinishSetupAds(),
                new LockScreenAds(),
                new PersonalizedAds(),
                new SettingsAds(),
                new StartmenuAds(),
                new TailoredExperiences(),
                new TipsAndSuggestions(),
                new WelcomeExperienceAds(),

                // Privacy
                new ActivityHistory(),
                new LocationTracking(),
                new PrivacyExperience(),
                new Telemetry(),

                // Personalization
                new SearchboxTaskbarMode(),
                new ShowOrHideMostUsedApps(),
                new ShowTaskViewButton(),
                new LockScreen(),
                new StartLayout(),
                new TaskbarAlignment(),
                new FullContextMenus(),

                // System
                new VerboseStatus(),
                new BSODDetails(),

                // AI
                new CopilotTaskbar(),
                new RecallUser(),
                new RecallMachine(),

                // Gaming
                new GameDVR(),
                new PowerThrottling(),
                new VisualFX(),
            };
        }

        public List<string> GetCategories()
        {
            var categories = features.Select(f => f.GetCategory()).Distinct().ToList();
            categories.Insert(0, "Start"); // Default category
            return categories;
        }

        public List<FeatureBase> GetFeatures(string category)
        {
            return category == "Start" ? features : features.Where(f => f.GetCategory().Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}