using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.System
{
    internal class BSODDetails : FeatureBase
    {
        private const string keyName = @"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\CrashControl";
        private const string valueName1 = "DisplayParameters";
        private const string valueName2 = "DisableEmoticon";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Values: {valueName1}, {valueName2} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Show BSOD details instead of the sad smiley";
        }

        public override string Info()
        {
            return "This method displays the full classic BSOD with technical error details instead of the simplified sad face version.";
        }

        public override bool CheckFeature()
        {
            return (
                Utils.IntEquals(keyName, valueName1, desiredValue) &&
                Utils.IntEquals(keyName, valueName2, desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName1, desiredValue, RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, desiredValue, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, valueName1, 0, RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, 0, RegistryValueKind.DWord);
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
