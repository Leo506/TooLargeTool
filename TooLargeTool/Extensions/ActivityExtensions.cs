using Android.Content;

namespace TooLargeTool.Extensions;

public static class ActivityExtensions
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

    private static void LogExtras(Activity activity, Intent intent, string operationName)
    {
        if (intent.Extras == null) 
            return;
        
        var bundleSizeData = BundleSizeCalculator.GetBundleSizeData(intent.Extras);
        Logger.LogBundleSizeData(bundleSizeData, activity.GetType().Name, operationName);
    }
}