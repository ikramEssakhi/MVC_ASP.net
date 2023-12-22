namespace WebApplication2
{
    using Microsoft.Extensions.Logging;
    using System;
    using System.IO;

    public static class LoggingExtensions
    {
        public static ILoggingBuilder AddFile(this ILoggingBuilder builder, string filePath)
        {
            builder.AddProvider(new FileLoggerProvider(filePath));
            return builder;
        }
    }

    public class FileLoggerProvider : ILoggerProvider
    {
        private readonly string filePath;

        public FileLoggerProvider(string filePath)
        {
            this.filePath = filePath;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(filePath);
        }

        public void Dispose()
        {
        }
    }

    public class FileLogger : ILogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var logMessage = $"{DateTime.Now} [{logLevel}] {formatter(state, exception)}";
            File.AppendAllText(filePath, logMessage + Environment.NewLine);
        }
    }
}
