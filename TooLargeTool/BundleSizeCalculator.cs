using Android.OS;
using TooLargeTool.Extensions;

namespace TooLargeTool;

internal static class BundleSizeCalculator
{
    public static BundleSizeData GetBundleSizeData(Bundle bundle)
    {
        var totalSize = GetBundleSizeInBytes(bundle).ToKb();
        var keysSizes = GetKeysSizes(bundle);

        return new BundleSizeData(totalSize, keysSizes);
    }

    private static Dictionary<string, double> GetKeysSizes(Bundle bundle)
    {
        var keysSizes = new Dictionary<string, double>();
        var bundleCopy = new Bundle(bundle);
        var tmp = GetKeySet(bundleCopy).ToList();
        foreach (var key in tmp)
        {
            var oldSize = GetBundleSizeInBytes(bundleCopy);

            bundleCopy.Remove(key);

            var newSize = GetBundleSizeInBytes(bundleCopy);

            keysSizes.Add(key, (oldSize - newSize).ToKb());
        }

        return keysSizes;
    }

    private static IEnumerable<string> GetKeySet(BaseBundle bundle)
    {
        return bundle.KeySet() ?? Enumerable.Empty<string>();
    }

    private static int GetBundleSizeInBytes(Bundle bundle)
    {
        var parcel = Parcel.Obtain();
        parcel.WriteBundle(bundle);
        return parcel.DataSize();
    }
}