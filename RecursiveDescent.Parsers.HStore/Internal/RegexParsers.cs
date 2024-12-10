using System.Text.RegularExpressions;

namespace RecursiveDescent.Parsers.HStore {

    internal sealed partial class CurlyOpenParser() : RegexParser<CurlyOpenNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^{", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override CurlyOpenNode CreateNode(string Value) {
            return new CurlyOpenNode() { Value = Value, };
        }
    }

    internal sealed partial class CurlyCloseParser() : RegexParser<CurlyCloseNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^}", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override CurlyCloseNode CreateNode(string Value) {
            return new CurlyCloseNode() { Value = Value, };
        }
    }

    internal sealed partial class CommaParser() : RegexParser<CommaNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^,", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override CommaNode CreateNode(string Value) {
            return new CommaNode() { Value = Value, };
        }
    }

    internal sealed partial class QuoteParser() : RegexParser<QuoteNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^""", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override QuoteNode CreateNode(string Value) {
            return new QuoteNode() { Value = Value, };
        }
    }

    internal sealed partial class ProducesParser() : RegexParser<ProducesNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^=>", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override ProducesNode CreateNode(string Value) {
            return new ProducesNode() { Value = Value, };
        }
    }

    internal sealed partial class ShortStringParser() : RegexParser<ShortStringNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^\w+", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override ShortStringNode CreateNode(string Value) {
            return new ShortStringNode() { Value = Value, };
        }
    }

    internal sealed partial class LongStringParser() : RegexParser<LongStringNode>(GetGeneratedRegex()) {

        [GeneratedRegex(@"^(\\""|[^""])*", RegexOptions.IgnoreCase)]
        private static partial Regex GetGeneratedRegex();

        protected override LongStringNode CreateNode(string Value) {
            return new LongStringNode() { Value = Value, };
        }
    }

}
