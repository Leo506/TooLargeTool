using Microsoft.Extensions.Logging;

namespace TooLargeTool.Logging;

public static class LogHost
{
    private static ILoggerFactory _loggerFactory;

    static LogHost() => ReplaceLogProvider(new AndroidLoggerProvider());

    public static ILogger<T> GetLogger<T>() => _loggerFactory.CreateLogger<T>();

    public static void ReplaceLogProvider(ILoggerProvider provider) =>
        _loggerFactory = LoggerFactory.Create(builder => builder.AddProvider(provider));
}