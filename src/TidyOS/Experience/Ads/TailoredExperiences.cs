using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.Ads
{
    internal class TailoredExperiences : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";
        private const string valueName = "TailoredExperiencesWithDiagnosticDataEnabled";
        private const int desiredValue = 0;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Disable Tailored experiences";
        }

        public override string Info()
        {
            return "Tailored Experiences allows Microsoft to get information from you to deliver personalized tips, ads, and recommendations. Many people would call this telemetry, or even spying.";
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