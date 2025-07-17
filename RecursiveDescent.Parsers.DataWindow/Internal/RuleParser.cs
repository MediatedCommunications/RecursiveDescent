namespace RecursiveDescent.Parsers.DataWindow; 

internal sealed class RuleParser : Parser<RuleNode> {

    public override ParserResult<RuleNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        {
            if (ret.Success is null && Grammars.RuleParser.TryParse(Context0) is {
                Context: var Context1,
                Success: (var Name, var Value)
            }) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Name = Name,
                        Value = Value,
                    },
                };

            }

        }

        return ret;

    }

}
