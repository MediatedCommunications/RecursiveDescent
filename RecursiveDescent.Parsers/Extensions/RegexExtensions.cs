using System.Text.RegularExpressions;

namespace RecursiveDescent.Parsers {
    internal static class RegexExtensions {
        public static bool Match(this Regex This, ReadOnlySpan<char> Input, out ValueMatch Value) {
            var ret = false;
            Value = default;

            var IE = This.EnumerateMatches(Input);

            if (IE.MoveNext()) {
                ret = true;
                Value = IE.Current;
            }

            return ret;
        }
    }

}
