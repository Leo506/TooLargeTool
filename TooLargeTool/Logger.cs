using System.Text;
using Microsoft.Extensions.Logging;
using TooLargeTool.Logging;

namespace TooLargeTool;

internal class Logger
{
    private readonly ILogger<Logger> _logger = LogHost.GetLogger<Logger>();

    public void LogBundleSizeData(BundleSizeData bundleSizeData, string objectName, string operationName)
    {
        var sb = new StringBuilder();
        sb.Append($"[{objectName}]");
        if (string.IsNullOrEmpty(operationName) is false)
            sb.Append($"[{operationName}]");
        sb.Append($" Total bundle size is {bundleSizeData.TotalSizeInKb:F1} KB with " +
                      $"{bundleSizeData.KeysSizes.Count} keys\n");
        
        foreach (var (key, size) in bundleSizeData.KeysSizes) 
            sb.AppendLine($"\t{key} - {size:F1} KB");

        _logger.LogInformation(sb.ToString());
    }
}