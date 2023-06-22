namespace TooLargeTool.Callbacks;

internal class FragmentLifecycleCallbacks : FragmentManager.FragmentLifecycleCallbacks
{
    public override void OnFragmentSaveInstanceState(FragmentManager? fm, Fragment? f, Bundle? outState)
    {
        if (outState is null)
            return;
        
        var bundleSizeData = BundleSizeCalculator.GetBundleSizeData(outState);
        new Logger().LogBundleSizeData(bundleSizeData, f?.GetType().Name ?? string.Empty,
            nameof(Fragment.OnSaveInstanceState));
    }
}