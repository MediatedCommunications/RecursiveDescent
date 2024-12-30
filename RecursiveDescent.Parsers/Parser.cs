namespace RecursiveDescent.Parsers {

    public abstract class Parser<TNode> : IParser<TNode> where TNode : Node {

        public abstract ParserResult<TNode> TryParse(ReadOnlySpan<char> Context0);

    }

}
