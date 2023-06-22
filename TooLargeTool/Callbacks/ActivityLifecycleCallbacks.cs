namespace TooLargeTool.Callbacks;

internal class ActivityLifecycleCallbacks : Java.Lang.Object, Application.IActivityLifecycleCallbacks
{
    private FragmentManager.FragmentLifecycleCallbacks? _callbacks;
    
    public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
    {
        var bundleSizeData = BundleSizeCalculator.GetBundleSizeData(outState);
        new Logger().LogBundleSizeData(bundleSizeData, activity.GetType().Name, nameof(Activity.OnSaveInstanceState));
    }
    
    public void OnActivityCreated(Activity activity, Bundle? savedInstanceState)
    {
        _callbacks = new FragmentLifecycleCallbacks();
        activity.FragmentManager?.RegisterFragmentLifecycleCallbacks(_callbacks, true);
    }

    public void OnActivityDestroyed(Activity activity)
    {
        activity.FragmentManager?.UnregisterFragmentLifecycleCallbacks(_callbacks);
    }
    
#region Unused properties and methods
public void OnActivityPaused(Activity activity) { }
    public void OnActivityResumed(Activity activity) { }
    public void OnActivityStarted(Activity activity) { }
    public void OnActivityStopped(Activity activity) { }
#endregion
}