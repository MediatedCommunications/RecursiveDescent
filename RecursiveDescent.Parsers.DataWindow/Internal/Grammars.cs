namespace RecursiveDescent.Parsers.DataWindow;
internal static class Grammars {
    public static IParser<ValueNode<AnyStringNode, AnyStringNode>> RuleParser { get; }

    public static IParser<ValueNode<AnyStringNode, RuleListNode>> MethodParser { get; }

    public static IParser<MethodListNode> RootParserRules { get; }

    static Grammars() {
        RuleParser = Primitives.And(
            Parsers.AnyString.AsWord(),
            Parsers.Produces.AsWord(),
            Parsers.AnyString.AsWord()
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value3));

        MethodParser = Primitives.And(
            Parsers.AnyString.AsWord(),
            Parsers.ParenOpen.AsWord(),
            Parsers.RuleList,
            Parsers.ParenClose.AsWord()
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value3));

        RootParserRules = Parsers.MethodList.AsWord();

    }
}
