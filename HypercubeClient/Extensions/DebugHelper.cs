using System.Diagnostics;

namespace Hypercube.Client.Extensions
{
    public static class DebugHelper
    {
        public static void Trace<T>(this T instance, string name)
            => Debug.Print($"[{nameof(Trace)}][{name} : {typeof(T)}]: {instance}");
    }
}
