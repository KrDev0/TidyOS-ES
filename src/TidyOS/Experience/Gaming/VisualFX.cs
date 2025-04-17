using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Gaming
{
    internal class VisualFX : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects";
        private const string valueName = "VisualFXSetting";
        private const int desiredValue = 2;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Disable Visual Effects";
        }

        public override string Info()
        {
            return "This feature will disable visual effects in Windows.";
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
                Registry.SetValue(keyName, valueName, 2, Microsoft.Win32.RegistryValueKind.DWord);

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