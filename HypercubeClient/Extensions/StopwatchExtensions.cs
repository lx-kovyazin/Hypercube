using System.Diagnostics;

namespace Hypercube.Client.Extensions
{
    internal static class StopwatchExtensions
    {
        internal static Stopwatch stopwatch;

        internal static T Start<T>(this T instance)
        {
            Debug.Print($"[Start] Type: {typeof(T)}");
            stopwatch = Stopwatch.StartNew();
            return instance;
        }

        internal static T Stop<T>(this T instance)
        {
            stopwatch.Stop();
            Debug.Print($"[Stop] Type: {typeof(T)}");
            Debug.Print($"[Stop] Elapsed: {stopwatch.Elapsed}");
            return instance;
        }
    }
}
