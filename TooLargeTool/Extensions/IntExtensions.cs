namespace TooLargeTool.Extensions;

internal static class IntExtensions
{
    public static double ToKb(this int bytesNumber) => bytesNumber / 1024.0;
}