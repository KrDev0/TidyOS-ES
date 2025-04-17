using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Personalization
{
    internal class StartLayout : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        private const string valueName = "Start_Layout";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Pin more Apps on start menu";
        }

        public override string Info()
        {
            return "This feature will allow pinning more Apps on start menu";
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
                Registry.SetValue(keyName, valueName, 1, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
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