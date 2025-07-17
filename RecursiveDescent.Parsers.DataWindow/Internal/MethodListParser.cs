namespace RecursiveDescent.Parsers.DataWindow; 

internal sealed class MethodListParser : Parser<MethodListNode> {

    public override ParserResult<MethodListNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        {



            if (ret.Success is null && Grammars.MethodListParser.TryParse(Context0) is {
                Context: var Context1,
                Success: {
                    Value1: { } Method,
                    Value2: var More,
                }
            }) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Method = Method,
                        More = More,
                    },
                };

            }

        }

        return ret;

        {
            if (ret.Success is null

                && Parsers.Method.AsWord().TryParse(Context0) is { Success: { } Method, Context: var Context1 }

                //&& Parsers.Comma.AsWord().TryParse(Context1) is { Success: { }, Context: var Context2 }

                && Parsers.MethodList.AsWord().TryParse(Context1) is { Success: { } More, Context: var Context2 }

                ) {

                ret = new() {
                    Context = Context2,
                    Success = new() {
                        Method = Method,
                        More = More,
                    },
                };

            }

        }

        {
            if (ret.Success is null

                && Parsers.Method.AsWord().TryParse(Context0) is { Success: { } Method, Context: var Context1 }

                ) {

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Method = Method,
                        More = default,
                    },
                };

            }

        }

        return ret;

    }

}
