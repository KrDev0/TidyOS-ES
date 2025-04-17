using System;
using System.IO;

public static class Logger
{
    private static readonly object _lock = new object();
    private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.log");

    /// <summary>
    /// Writes a log message to the file.
    /// </summary>
    public static void Log(string message, LogLevel level = LogLevel.Info)
    {
        string formattedMessage = $"[{DateTime.Now:HH:mm:ss}] [{level}] {message}";
        WriteToFile(formattedMessage);
    }

    /// <summary>
    /// Writes the formatted message to the log file in a thread-safe manner.
    /// </summary>
    private static void WriteToFile(string message)
    {
        try
        {
            lock (_lock)
            {
                File.AppendAllText(logFilePath, message + Environment.NewLine);
            }
        }
        catch (Exception ex)
        {
            // If writing to the file fails, output an error message to the console
            Console.WriteLine($"Error writing to log file: {ex.Message}");
        }
    }
}

public enum LogLevel
{
    Info,
    Error,
    Warning
}
