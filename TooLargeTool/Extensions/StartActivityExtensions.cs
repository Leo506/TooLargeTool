using Android.Content;
using Java.Interop;

namespace TooLargeTool.Extensions;

public static class StartActivityExtensions
{
    public static void StartActivityWithLoggingExtras(this Activity activity, Intent intent)
    {
        LogExtras(activity, intent, nameof(Activity.StartActivity));
        activity.StartActivity(intent);
    }
    
    public static void StartActivityWithLoggingExtras(this Activity activity, Intent intent, Bundle? options)
    {
        LogExtras(activity, intent, nameof(Activity.StartActivity));
        activity.StartActivity(intent, options);
    }

    public static void StartActivityForResultWithLoggingExtras(this Activity activity, Intent intent, int requestCode)
    {
        LogExtras(activity, intent, nameof(Activity.StartActivityForResult));
        activity.StartActivityForResult(intent, requestCode);
    }

    public static void StartActivityForResultWithLoggingExtras(this Activity activity, Intent intent, int requestCode,
        Bundle? options)
    {
        LogExtras(activity, intent, nameof(Activity.StartActivityForResult));
        activity.StartActivityForResult(intent, requestCode, options);
    }

    public static void StartActivitiesWithLoggingExtras(this Activity activity, Intent[] intents)
    {
        foreach (var intent in intents) LogExtras(activity, intent, nameof(Activity.StartActivities));
        activity.StartActivities(intents);
    }

    public static void StartActivityWithLoggingExtras(this Fragment fragment, Intent intent)
    {
        LogExtras(fragment, intent, nameof(fragment.StartActivity));
        fragment.StartActivity(intent);
    }
    
    public static void StartActivityWithLoggingExtras(this Fragment fragment, Intent intent, Bundle? options)
    {
        LogExtras(fragment, intent, nameof(fragment.StartActivity));
        fragment.StartActivity(intent, options);
    }
    
    public static void StartActivityForResultWithLoggingExtras(this Fragment fragment, Intent intent, int requestCode)
    {
        LogExtras(fragment, intent, nameof(fragment.StartActivity));
        fragment.StartActivityForResult(intent, requestCode);
    }

    public static void StartActivityForResultWithLoggingExtras(this Fragment fragment, Intent intent, int requestCode, Bundle? options)
    {
        LogExtras(fragment, intent, nameof(fragment.StartActivity));
        fragment.StartActivityForResult(intent, requestCode, options);
    }
    
    private static void LogExtras(IJavaPeerable javaObject, Intent intent, string operationName)
    {
        if (intent.Extras == null) 
            return;
        
        var bundleSizeData = BundleSizeCalculator.GetBundleSizeData(intent.Extras);
        new Logger().LogBundleSizeData(bundleSizeData, javaObject.GetType().Name, operationName);
    }
}