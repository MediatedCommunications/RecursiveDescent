namespace RecursiveDescent.Parsers.DataWindow; 

internal sealed class RuleListParser : Parser<RuleListNode> {

    public override ParserResult<RuleListNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        {



            if (ret.Success is null && Grammars.RuleListParser.TryParse(Context0) is {
                Context: var Context1,
                Success: {
                    Value1: { } Rule,
                    Value2: var More,
                }
            }) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Rule = Rule,
                        More = More,
                    },
                };

            }

        }

        return ret;

        {
            if (ret.Success is null

                && Parsers.Rule.AsWord().TryParse(Context0) is { Success: { } Rule, Context: var Context1 }

                && Parsers.RuleList.AsWord().TryParse(Context1) is { Success: { } More, Context: var Context2 }

                ) {

                ret = new() {
                    Context = Context2,
                    Success = new() {
                        Rule = Rule,
                        More = More,
                    },
                };

            }

        }

        {
            if (ret.Success is null

                && Parsers.Rule.AsWord().TryParse(Context0) is { Success: { } Rule, Context: var Context1 }

                ) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Rule = Rule,
                        More = default,
                    },
                };

            }

        }

        return ret;

    }

}
