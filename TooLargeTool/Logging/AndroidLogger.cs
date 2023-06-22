using Microsoft.Extensions.Logging;

namespace TooLargeTool.Logging;

internal class AndroidLogger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        Android.Util.Log.Info(nameof(TooLargeTool), formatter(state, exception));
    }

    public bool IsEnabled(LogLevel logLevel) => true;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;
}