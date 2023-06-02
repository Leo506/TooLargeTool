using Android.OS;
using Android.Util;
using Java.Interop;

namespace TooLargeTool;

public class ActivityCallback : Java.Lang.Object, Application.IActivityLifecycleCallbacks
{
    public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
    {
        var p = Parcel.Obtain();
        p.WriteBundle(outState);
        Log.Info(nameof(TooLargeTool), $"Bundle size: {p.DataSize()} bytes");
    }
#region Unused properties and methods
    public void OnActivityCreated(Activity activity, Bundle? savedInstanceState) { }
    public void OnActivityDestroyed(Activity activity) { }
    public void OnActivityPaused(Activity activity) { }
    public void OnActivityResumed(Activity activity) { }
    public void OnActivityStarted(Activity activity) { }
    public void OnActivityStopped(Activity activity) { }
#endregion
}