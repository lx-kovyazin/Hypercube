using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace Hypercube.Client.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> RotateLeft<T>(this IEnumerable<T> inner)
            => inner.Move(0, 1, inner.Count() - 1);

        public static IEnumerable<T> RotateRight<T>(this IEnumerable<T> inner)
            => inner.Move(inner.Count() - 1, 1, 0);
    }
}
