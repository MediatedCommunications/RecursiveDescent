namespace RecursiveDescent.Parsers.HStore {

    internal sealed class CurlyOpenParser() : RegexParser<CurlyOpenNode>(@"{") {
        protected override CurlyOpenNode CreateNode(string Value) {
            return new CurlyOpenNode() { Value = Value, };
        }
    }

    internal sealed class CurlyCloseParser() : RegexParser<CurlyCloseNode>(@"}") {
        protected override CurlyCloseNode CreateNode(string Value) {
            return new CurlyCloseNode() { Value = Value, };
        }
    }

    internal sealed class CommaParser() : RegexParser<CommaNode>(@",") {
        protected override CommaNode CreateNode(string Value) {
            return new CommaNode() { Value = Value, };
        }
    }

    internal sealed class QuoteParser() : RegexParser<QuoteNode>(@"""") {
        protected override QuoteNode CreateNode(string Value) {
            return new QuoteNode() { Value = Value, };
        }
    }

    internal sealed class ProducesParser() : RegexParser<ProducesNode>("=>") {
        protected override ProducesNode CreateNode(string Value) {
            return new ProducesNode() { Value = Value, };
        }
    }

    internal sealed class ShortStringParser() : RegexParser<ShortStringNode>(@"\w+") {
        protected override ShortStringNode CreateNode(string Value) {
            return new ShortStringNode() { Value = Value, };
        }
    }

    internal sealed class LongStringParser() : RegexParser<LongStringNode>(@"(\\""|[^""])*") {
        protected override LongStringNode CreateNode(string Value) {
            return new LongStringNode() { Value = Value, };
        }
    }

}
