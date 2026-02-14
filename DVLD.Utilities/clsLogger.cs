using System;
using System.Diagnostics;

namespace DVLD.Utilities
{
    public static class clsLogger
    {
        private const string _sourceName = "DVLD_App";

        public static void LogError(string message) => _LogToEventLog(message, EventLogEntryType.Error);

        public static void LogError(Exception ex)
            => _LogToEventLog($"Message: {ex.Message}\n\nStack: {ex.StackTrace}", EventLogEntryType.Error);

        public static void LogError(string customMessage, Exception ex)
            => _LogToEventLog($"{customMessage}\n\nException: {ex.Message}\n\nStack: {ex.StackTrace}", EventLogEntryType.Error);

        public static void Log(string message, EventLogEntryType type) => _LogToEventLog(message, type);

        private static void _LogToEventLog(string message, EventLogEntryType type)
        {
            try
            {
                if (!EventLog.SourceExists(_sourceName))
                {
                    EventLog.CreateEventSource(_sourceName, "Application");
                }
                EventLog.WriteEntry(_sourceName, message, type);
            }
            catch { }
        }
    }

}
