namespace RecursiveDescent.Parsers {
    public interface IParser<TNode> where TNode : Node {
        ParserResult<TNode> TryParse(ReadOnlySpan<char> Context0);
    }

}
