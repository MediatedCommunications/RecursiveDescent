
namespace RecursiveDescent.Parsers {
    public readonly struct OptionalParser<TNode> : IParser<OptionalNode<TNode>> where TNode : Node {

        public OptionalParser(IParser<TNode> Child) {
            this.Child = Child;
        }

        public IParser<TNode> Child { get; }

        public ParserResult<OptionalNode<TNode>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Child.TryParse(Context0) is { Success: { } Value, Context: var Context1 }

                    ) {

                    ret = new() {
                        Context = Context1,
                        Success = new() { Value = Value, },
                    };

                }

            }

            {
                if (ret.Success is null) {
                    ret = new() {
                        Context = Context0,
                        Success = new() { Value = default, }
                    };
                }
            }

            return ret;
        }
    }

}
