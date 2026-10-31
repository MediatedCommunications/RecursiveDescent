namespace RecursiveDescent.Parsers.HStore; 

internal sealed class RootParser : Parser<RootNode> {
    public override ParserResult<RootNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        var parsed = Grammars.RootParserRules.TryParse(Context0);
        if (parsed.Success is { } Rules && parsed.Context.IsEmpty) {
            ret = new() {
                Context = parsed.Context,
                Success = new() {
                    Rules = Rules,
                },
            };
        }

        if (ret.Success is null) {
            var whitespace = Primitives.WhiteSpace.TryParse(Context0);
            if (whitespace.Success is { } && whitespace.Context.IsEmpty) {
                ret = new() {
                    Context = whitespace.Context,
                    Success = new() {
                        Rules = default,
                    },
                };
            }
        }

        return ret;
    }


}
