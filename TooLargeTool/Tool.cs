using Microsoft.Extensions.Logging;
using TooLargeTool.Callbacks;
using TooLargeTool.Logging;

namespace TooLargeTool;

public static class Tool
{
    public static void StartBundleLogging(Application app, ILoggerProvider loggerProvider)
    {
        StartBundleLogging(app);
        LogHost.ReplaceLogProvider(loggerProvider);
    }

    public static void StartBundleLogging(Application app)
    {
        app.RegisterActivityLifecycleCallbacks(new ActivityLifecycleCallbacks());
    }
}