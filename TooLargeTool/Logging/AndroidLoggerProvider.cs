using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace TooLargeTool.Logging;

internal class AndroidLoggerProvider : ILoggerProvider
{
    private readonly ConcurrentDictionary<string, AndroidLogger> _loggers = new(StringComparer.OrdinalIgnoreCase);

    public void Dispose() => _loggers.Clear();

    public ILogger CreateLogger(string categoryName) => _loggers.GetOrAdd(categoryName, new AndroidLogger());
}