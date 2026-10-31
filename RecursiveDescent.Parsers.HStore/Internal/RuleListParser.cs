namespace RecursiveDescent.Parsers.HStore;

internal sealed class RuleListParser : Parser<RuleListNode> {

    private static class Words {
        public static IParser<RuleNode> Rule { get; } = Parsers.Rule.AsWord();
        public static IParser<CommaNode> Comma { get; } = Parsers.Comma.AsWord();
    }

    public override ParserResult<RuleListNode> TryParse(ReadOnlySpan<char> Context0) {
        var ret = this.DefaultResult(Context0);

        if (Words.Rule.TryParse(Context0) is not { Success: { } First, Context: var Context }) {
            return ret;
        }

        var rules = new List<RuleNode> { First };

        while (Words.Comma.TryParse(Context) is { Success: { }, Context: var AfterComma }
            && Words.Rule.TryParse(AfterComma) is { Success: { } Next, Context: var AfterRule }) {
            rules.Add(Next);
            Context = AfterRule;
        }

        var head = new RuleListNode {
            Rule = rules[^1],
            More = null,
        };

        for (var i = rules.Count - 2; i >= 0; i--) {
            head = new RuleListNode {
                Rule = rules[i],
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
