﻿using Microsoft.Win32;
using System;
using TidyOS;

namespace Settings.AI
{
    internal class RecallUser : FeatureBase
    {
        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\WindowsAI";
        private const string valueName = "DisableAIDataAnalysis";
        private const int desiredValue = 0;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return "Don't Allow Windows to save snapshots of your screen";
        }

        public override string Info()
        {
            return "This feature will disable Recall from saving snapshots of your screen.";
        }

        public override bool CheckFeature()
        {
            // Check if reg key exists
            object value = Registry.GetValue(keyName, valueName, null);
            if (value == null)
            {
                // Key does not exist, turn off feature
                return false;
            }

            // Key exists, check if value is desired value
            return (int)value != desiredValue;
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 1, Microsoft.Win32.RegistryValueKind.DWord);
                Logger.Log("You've got snapshots disabled.", LogLevel.Info);
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
                Registry.SetValue(keyName, valueName, desiredValue, Microsoft.Win32.RegistryValueKind.DWord);
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