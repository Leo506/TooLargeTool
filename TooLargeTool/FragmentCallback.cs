using Android.OS;
using Android.Util;

namespace TooLargeTool;

public class FragmentCallback : FragmentManager.FragmentLifecycleCallbacks
{
    public override void OnFragmentSaveInstanceState(FragmentManager? fm, Fragment? f, Bundle? outState)
    {
        var p = Parcel.Obtain();
        p.WriteBundle(outState);
        Log.Info(nameof(TooLargeTool), $"Fragment bundle size: {p.DataSize()} bytes");
    }
}