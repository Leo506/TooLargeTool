using System.Text;
using Android.Util;

namespace TooLargeTool;

internal static class Logger
{
    public static void LogBundleSizeData(BundleSizeData bundleSizeData, string objectName, string operationName)
    {
        var sb = new StringBuilder();
        sb.Append($"[{objectName}]");
        if (string.IsNullOrEmpty(operationName) is false)
            sb.Append($"[{operationName}]");
        sb.Append($" Total bundle size is {bundleSizeData.TotalSizeInKb:F1} KB with " +
                      $"{bundleSizeData.KeysSizes.Count} keys\n");
        
        foreach (var (key, size) in bundleSizeData.KeysSizes) 
            sb.AppendLine($"\t{key} - {size:F1} KB");

        Log.Info(nameof(TooLargeTool), sb.ToString());
    }
}