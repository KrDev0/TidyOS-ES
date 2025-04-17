using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.AI
{
    internal class CopilotTaskbar : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\WindowsCopilot";
        private const string valueName = "TurnOffWindowsCopilot";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Don't Show Copilot in Taskbar";
        }

        public override string Info()
        {
            return "This feature will disable Copilot in Taskbar.";
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, 1);
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