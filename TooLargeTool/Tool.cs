using TooLargeTool.Callbacks;

namespace TooLargeTool;

public static class Tool
{
    public static void StartBundleLogging(Application app)
    {
        app.RegisterActivityLifecycleCallbacks(new ActivityLifecycleCallbacks());
    }
}