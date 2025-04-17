using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Gaming
{
    internal class PowerThrottling : FeatureBase
    {
        private const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling";
        private const string valueName = "PowerThrottlingOff";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Disable Power Throttling";
        }

        public override string Info()
        {
            return "This feature will disable Power Throttling.";
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, desiredValue);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, desiredValue, Microsoft.Win32.RegistryValueKind.DWord);

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