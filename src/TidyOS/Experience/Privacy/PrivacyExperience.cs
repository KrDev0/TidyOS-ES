using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Privacy
{
    public class PrivacyExperience : FeatureBase
    {
        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OOBE";
        private const string valueName = "DisablePrivacyExperience";
        private const int desiredValue = 0;

        public override string ID() => "Disable Privacy Settings Experience at sign-in";

        public override string Info() => "This feature will disable Privacy Settings Experience at sign-in.";

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return !Utils.IntEquals(keyName, valueName, desiredValue);
        }

        public override bool DoFeature()
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

        public override bool UndoFeature()
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
    }
}