namespace RecursiveDescent.Parsers.DataWindow;

internal sealed class MethodListParser : Parser<MethodListNode> {

    private static class Words {
        public static IParser<MethodNode> Method { get; } = Parsers.Method.AsWord();
    }

    public override ParserResult<MethodListNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        if (Words.Method.TryParse(Context0) is not { Success: { } First, Context: var Context }) {
            return ret;
        }

        var methods = new List<MethodNode> { First };

        while (Words.Method.TryParse(Context) is { Success: { } Next, Context: var AfterMethod }) {
            methods.Add(Next);
            Context = AfterMethod;
        }

        var head = new MethodListNode {
            Method = methods[^1],
            More = null,
        };

        for (var i = methods.Count - 2; i >= 0; i--) {
            head = new MethodListNode {
                Method = methods[i],
                More = head,
            };
        }

        ret = new() {
            Context = Context,
            Success = head,
        };

        return ret;
    }

}
