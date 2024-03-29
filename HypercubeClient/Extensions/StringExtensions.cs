﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Extensions
{
    public static class StringExtensions
    {
        [SuppressMessage("Design", "CC0031:Check for null before calling a delegate", Justification = "Not required.")]
        public static string NotMatch(this string @string, Predicate<string> pattern)
            => pattern(@string) ? null : @string;

        public static bool IsNullOrEmptyOrWhiteSpace(this string @string)
            => string.IsNullOrEmpty(@string)
            || string.IsNullOrWhiteSpace(@string);

        public static bool IsValuable(this string @string)
            => !IsNullOrEmptyOrWhiteSpace(@string);
    }
}
