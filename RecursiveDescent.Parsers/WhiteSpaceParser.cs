namespace RecursiveDescent.Parsers {
    public sealed class WhiteSpaceParser() : RegexParser<WhiteSpaceNode>(@"\s*") {
        protected override WhiteSpaceNode CreateNode(string Value) {
            return new WhiteSpaceNode() { Value = Value, };
        }
    }

}
