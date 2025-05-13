namespace RecursiveDescent.Parsers; 
public readonly struct WordParser<TNode> : IParser<TNode> where TNode : Node {

    public WordParser(IParser<TNode> Child) {
        this.Child = Child;

        this.Grammar = Primitives
            .And(Primitives.WhiteSpace, Child, Primitives.WhiteSpace)
            .Transform(x => x.Value2)
            ;

    }

    public IParser<TNode> Child { get; }
    private IParser<TNode> Grammar { get; }

    public ParserResult<TNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        {
            if (ret.Success is null && Grammar.TryParse(Context0) is {
                Context: var Context1,
                Success: { } Value,
            }) {

                ret = new() {
                    Context = Context1,
                    Success = Value,
                };

            }

        }

        return ret;
    }
}
