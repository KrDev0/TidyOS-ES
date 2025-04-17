using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace TidyOS
{
    internal class Utils
    {
        /// <summary>
        /// Check registry int equal
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="expectedValue"></param>
        /// <returns></returns>
        public static bool IntEquals(string keyName, string valueName, int expectedValue)
        {
            try
            {
                var value = Registry.GetValue(keyName, valueName, null);
                return (value != null && (int)value == expectedValue);
            }
            catch (Exception ex)

            {
                MessageBox.Show(keyName, ex.Message, MessageBoxButtons.OK);
                return false;
            }
        }

        /// <summary>
        /// Check registry string equal
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="expectedValue"></param>
        /// <returns></returns>
        public static bool StringEquals(string keyName, string valueName, string expectedValue)
        {
            try
            {
                var value = Registry.GetValue(keyName, valueName, null);

                return (value != null && (string)value == expectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(keyName, ex.Message, MessageBoxButtons.OK);
                return false;
            }
        }
    }
}