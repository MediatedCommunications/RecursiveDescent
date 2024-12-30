using System.Text.RegularExpressions;

namespace RecursiveDescent.Parsers {
    public abstract class RegexParser<TNode> : Parser<TNode> where TNode : Node {

        protected Regex RX { get; }

        public RegexParser(Regex RX) {
            this.RX = RX;
        }

        public RegexParser(string Value) {
            this.RX = new Regex($@"^{Value}", RegexOptions.Compiled);
        }

        public override ParserResult<TNode> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);


            if (RX.Match(Context0, out var Match) && CreateNode(Context0, Match) is { } Node) {
                ret = Context0.MoveNext(Node, Match);
            }

            return ret;
        }

        protected TNode CreateNode(ReadOnlySpan<char> Context, ValueMatch Match) {
            var Value = new string(Context[..Match.Length]);

            return CreateNode(Value);
        }

        protected abstract TNode CreateNode(string Value);

    }

}
