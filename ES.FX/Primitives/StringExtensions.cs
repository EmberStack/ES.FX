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
    }
}
