

namespace RecursiveDescent.Parsers {

    public readonly struct TransformParser<TInput, TOutput> : IParser<TOutput>
        where TInput : Node
        where TOutput : Node {

        public TransformParser(IParser<TInput> Input, Func<TInput, TOutput> Transform) {
            this.Input = Input;
            this.Transform = Transform;
        }

        public IParser<TInput> Input { get; }
        public Func<TInput, TOutput> Transform { get; }

        public ParserResult<TOutput> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null
                    && Input.TryParse(Context0) is { Success: { } OriginalValue, Context: var Context1 }
                    ) {

                    var NewValue = Transform(OriginalValue);

                    ret = new() {
                        Context = Context1,
                        Success = NewValue,
                    };

                }
            }


            return ret;
        }
    }
}
