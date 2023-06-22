namespace TooLargeTool.Callbacks;

internal class FragmentLifecycleCallbacks : FragmentManager.FragmentLifecycleCallbacks
{
    private readonly Logger _logger = new();
    public override void OnFragmentSaveInstanceState(FragmentManager? fm, Fragment? f, Bundle? outState)
    {
        if (outState is null)
            return;
        
        var bundleSizeData = BundleSizeCalculator.GetBundleSizeData(outState);
        _logger.LogBundleSizeData(bundleSizeData, f?.GetType().Name ?? string.Empty, nameof(Fragment.OnSaveInstanceState));
    }
}