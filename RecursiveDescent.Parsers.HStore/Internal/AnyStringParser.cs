namespace RecursiveDescent.Parsers.HStore; 
internal class AnyStringParser : Parser<AnyStringNode> {

    private static string DecodeValue(string Input) {
        var ret = Input;

        ret = ret.Replace($@"\""", $@"""");
        ret = ret.Replace($@"\\", $@"\");

        return ret;
    }

    public override ParserResult<AnyStringNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        {
            if (ret.Success is null
                && Primitives.WhiteSpace.TryParse(Context0) is { Success: { }, Context: var Context1 } V1

                && Parsers.Quote.TryParse(Context1) is { Success: { }, Context: var Context2 } V2

                && Parsers.LongString.TryParse(Context2) is { Success: { } Value, Context: var Context3 } V3

                && Parsers.Quote.TryParse(Context3) is { Success: { }, Context: var Context4 } V4

                && Primitives.WhiteSpace.TryParse(Context4) is { Success: { }, Context: var Context5 } V5

                ) {

                var NewValue = DecodeValue(Value.Value);

                ret = new() {
                    Context = Context5,
                    Success = new() {
                        Value = NewValue,
                    },
                };

            }

        }

        {
            if (ret.Success is null

                && Parsers.ShortString.AsWord().TryParse(Context0) is { Success: { } Value, Context: var Context1 } V1

                ) {

                var NewValue = Value.Value;

                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Value = NewValue,
                    },
                };

            }

        }

        {
            if (ret.Success is null

                && Parsers.Quote.AsWord().TryParse(Context0) is { Success: { } Value, Context: var Context1 } V1

                ) {


                ret = new() {
                    Context = Context1,
                    Success = new() {
                        Value = string.Empty,
                    },
                };

            }

        }

        return ret;

    }

}
