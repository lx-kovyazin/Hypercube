using System;
using System.Diagnostics;

namespace Hypercube.Client.Extensions
{
    internal static class StopwatchHelper
    {
        internal static Stopwatch stopwatch = new Stopwatch();

        internal static T Start<T>(this T instance)
        {
            Debug.Print($"[Start] Type: {typeof(T)}");
            stopwatch.Start();
            return instance;
        }

        internal static T Stop<T>(this T instance, out TimeSpan elapsed)
        {
            stopwatch.Stop();
            elapsed = stopwatch.Elapsed;
            Debug.Print($"[Stop] Type: {typeof(T)}");
            Debug.Print($"[Stop] Elapsed: {elapsed}");
            return instance;
        }
    }
}
