namespace TooLargeTool;

internal record BundleSizeData(
        double TotalSizeInKb,
        Dictionary<string, double> KeysSizes
);