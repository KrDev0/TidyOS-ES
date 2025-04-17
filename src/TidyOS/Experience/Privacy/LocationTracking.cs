using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Privacy
{
    internal class LocationTracking : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\LocationAndSensors";
        private const string valueName = "LocationEnabled";
        private const int desiredValue = 0;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Disable location tracking";
        }

        public override string Info()
        {
            return "Disable location tracking (prevents Windows from accessing your location)";
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, desiredValue);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, valueName, 1, RegistryValueKind.DWord);

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