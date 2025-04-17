using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Ads
{
    public class WelcomeExperienceAds : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string valueName = "SubscribedContent-310093Enabled";
        private const int desiredValue = 0;

        public override string ID() => "Disable Welcome Experience Ads";

        public override string Info() => "This feature will disable ads in the welcome experience.";

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, 0);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Code red in " + ex.Message, LogLevel.Error);
            }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 1, Microsoft.Win32.RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Code red in " + ex.Message, LogLevel.Error);
            }

            return false;
        }
    }
}