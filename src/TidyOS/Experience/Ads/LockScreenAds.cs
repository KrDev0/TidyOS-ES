using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Ads
{
    internal class LockScreenAds : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string valueName = "RotatingLockScreenOverlayEnabled";
        private const string valueName2 = "SubscribedContent-338387Enabled";
        private const int desiredValue = 0;

        public override string ID() => "Disable Lock Screen Tips and Ads";

        public override string Info() => "This feature will disable tips and ads on the lock screen.";

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return (Utils.IntEquals(keyName, valueName, desiredValue) &&
                   Utils.IntEquals(keyName, valueName2, desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, 0, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName2, 1, Microsoft.Win32.RegistryValueKind.DWord);

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