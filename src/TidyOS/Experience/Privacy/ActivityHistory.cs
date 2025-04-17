using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Privacy
{
    internal class ActivityHistory : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";
        private const string valueName = "ActivityHistoryEnabled";
        private const int desiredValue = 0;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Disable activity history";
        }

        public override string Info()
        {
            return "Disable activity history (prevents Windows from tracking and storing your activity)";
        }

        public override bool CheckFeature()
        {
            return (
               Utils.IntEquals(keyName, valueName, desiredValue)
         );
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