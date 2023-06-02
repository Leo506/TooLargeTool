namespace TooLargeTool.Callbacks;

internal class ActivityLifecycleCallbacks : Java.Lang.Object, Application.IActivityLifecycleCallbacks
{
    private FragmentManager.FragmentLifecycleCallbacks? _callbacks;
    
    public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
    {
        var bundleSizeData = BundleSizeCalculator.GetBundleSizeData(outState);
        Logger.LogBundleSizeData(bundleSizeData, activity.GetType().Name);
    }
    
#region Unused properties and methods

    public void OnActivityCreated(Activity activity, Bundle? savedInstanceState)
    {
        _callbacks = new FragmentLifecycleCallbacks();
        activity.FragmentManager?.RegisterFragmentLifecycleCallbacks(_callbacks, true);   
    }

    public void OnActivityDestroyed(Activity activity)
    {
        activity.FragmentManager?.UnregisterFragmentLifecycleCallbacks(_callbacks);
    }
    public void OnActivityPaused(Activity activity) { }
    public void OnActivityResumed(Activity activity) { }
    public void OnActivityStarted(Activity activity) { }
    public void OnActivityStopped(Activity activity) { }
#endregion
}