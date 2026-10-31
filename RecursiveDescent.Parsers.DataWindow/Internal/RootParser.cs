namespace RecursiveDescent.Parsers.DataWindow;

internal sealed class RootParser : Parser<RootNode> {
    public override ParserResult<RootNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        var parsed = Grammars.RootParserRules.TryParse(Context0);
        if (parsed.Success is { } Methods && parsed.Context.IsEmpty) {
            ret = new() {
                Context = parsed.Context,
                Success = new() {
                    Methods = Methods,
                },
            };
        }

        if (ret.Success is null) {
            var whitespace = Primitives.WhiteSpace.TryParse(Context0);
            if (whitespace.Success is { } && whitespace.Context.IsEmpty) {
                ret = new() {
                    Context = whitespace.Context,
                    Success = new() {
                        Methods = default,
                    },
                };
            }
        }

        return ret;
    }


}
