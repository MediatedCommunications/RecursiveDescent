namespace RecursiveDescent.Parsers.HStore; 
internal static class Grammars {
    public static IParser<ValueNode<AnyStringNode, AnyStringNode>> RuleParser { get; }
    public static IParser<RuleListNode> RootParserRules { get; }

    static Grammars() {
        RuleParser = Primitives.And(
            Parsers.AnyString.AsWord(),
            Parsers.Produces.AsWord(),
            Parsers.AnyString.AsWord()
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value3));

        var rulesInBraces = Primitives.And(
            Parsers.CurlyOpen.AsWord(),
            Parsers.RuleList.AsWord(),
            Parsers.CurlyClose.AsWord()
        ).Transform(x => x.Value2);

        var emptyBraces = Primitives.And(
            Parsers.CurlyOpen.AsWord(),
            Parsers.CurlyClose.AsWord()
        ).Transform(static _ => new RuleListNode {
            Rule = null,
            More = null,
        });

        RootParserRules = Primitives.Or([
            Parsers.RuleList.AsWord(),
            rulesInBraces,
            emptyBraces,
        ]);

    }
}
