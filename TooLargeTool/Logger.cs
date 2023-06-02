using System.Text;
using Android.Util;

namespace TooLargeTool;

internal static class Logger
{
    public static void LogBundleSizeData(BundleSizeData bundleSizeData, string objectName)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"[{objectName}] Total bundle size is {bundleSizeData.TotalSizeInKb:F1} KB with " +
                      $"{bundleSizeData.KeysSizes.Count} keys");
        
        foreach (var (key, size) in bundleSizeData.KeysSizes)
        {
            sb.AppendLine($"\t{key} - {size:F1} bytes");
        }

        Log.Info(nameof(TooLargeTool), sb.ToString());
    }
}