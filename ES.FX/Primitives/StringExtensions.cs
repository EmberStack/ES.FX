using System;

namespace ES.FX.Primitives
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }

        public static bool IsNullOrEmpty(this string source)
        {
            return string.IsNullOrEmpty(source);
        }

        public static string IsInterned(this string source)
        {
            return string.IsInterned(source);
        }

        public static string WithMaxLength(this string source, int maxLength)
        {
            return source.WithMaxLength(0, Math.Min(source.Length, maxLength));
        }

        public static string WithMaxLength(this string source, int startIndex, int maxLength)
        {
            return source?.Substring(startIndex, Math.Min(source.Length, maxLength));
        }
    }
}
