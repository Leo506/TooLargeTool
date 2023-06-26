using Microsoft.Extensions.Logging;
using TooLargeTool.Callbacks;
using TooLargeTool.Logging;

namespace TooLargeTool;

public static class Tool
{
    private static bool _isStarted = false;
    
    public static void StartBundleLogging(Application app, ILoggerProvider loggerProvider)
    {
        StartBundleLogging(app);
        LogHost.ReplaceLogProvider(loggerProvider);
    }

    public static void StartBundleLogging(Application app)
    {
        if (_isStarted)
            return;
        
        app.RegisterActivityLifecycleCallbacks(new ActivityLifecycleCallbacks());
        _isStarted = true;
    }
}