namespace RecursiveDescent.Parsers.HStore; 

internal sealed class RootParser : Parser<RootNode> {
    public override ParserResult<RootNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);


        {

            if (ret.Success is null
                && Grammars.RootParserRules.TryParse(Context0) is { Success: { } Rules, Context: var Context1 }
                ) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Rules = Rules,
                    },
                };
            }
        }

        {

            if (ret.Success is null
                && Primitives.WhiteSpace.TryParse(Context0) is { Success: { }, Context: var Context1 }
                ) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Rules = default,
                    },
                };
            }
        }

        return ret;
    }


}
