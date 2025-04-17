using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.System
{
    internal class VerboseStatus : FeatureBase
    {
        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
        private const string valueName = "VerboseStatus";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Enable Verbose Logon status messages";
        }

        public override string Info()
        {
            return "This method allows you to see what processes are hanging when shutting down and turning on the machine.";
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
                Registry.SetValue(keyName, valueName, desiredValue, RegistryValueKind.DWord);
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