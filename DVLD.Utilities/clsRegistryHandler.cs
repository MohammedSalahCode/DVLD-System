using System;
using Microsoft.Win32;

namespace DVLD.Utilities
{
    public static class clsRegistryHandler
    {

        private const string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

        /// <summary>
        /// Saves or updates a string value in the Windows Registry under the DVLD key.
        /// </summary>
        /// <param name="valueName">The name of the value (Key) to store.</param>
        /// <param name="valueData">The string data to be stored.</param>
        /// <returns>True if the operation succeeded; otherwise, false.</returns>
        public static bool SetValue(string valueName, string valueData)
        {
            try
            {
                Registry.SetValue(_keyPath, valueName, valueData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                clsLogger.LogError("Registry Save Error", ex);
                return false;
            }
        }

        /// <summary>
        /// Retrieves a string value from the Windows Registry. Returns an empty string if not found.
        /// </summary>
        /// <param name="valueName">The name of the value to retrieve.</param>
        /// <returns>The stored string value or an empty string.</returns>
        public static string GetValue(string valueName)
        {
            try
            {
                return Registry.GetValue(_keyPath, valueName, null) as string ?? string.Empty;
            }
            catch (Exception ex)
            {
                clsLogger.LogError("Registry Read Error", ex);
                return string.Empty;
            }
        }
    }
}
