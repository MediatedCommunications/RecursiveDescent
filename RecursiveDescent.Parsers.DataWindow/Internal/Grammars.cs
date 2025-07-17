namespace RecursiveDescent.Parsers.DataWindow; 
internal static class Grammars {
    public static IParser<ValueNode<AnyStringNode, AnyStringNode>> RuleParser { get; }
    public static IParser<ValueNode<RuleNode, RuleListNode>> RuleListParser { get; }

    public static IParser<ValueNode<AnyStringNode, RuleListNode>> MethodParser { get; }
    public static IParser<ValueNode<MethodNode, MethodListNode>> MethodListParser { get; }
    
    public static IParser<MethodListNode> RootParserRules { get; }

    static Grammars() {
        RuleParser = Primitives.And(
            Parsers.AnyString.AsWord(),
            Parsers.Produces.AsWord(),
            Parsers.AnyString.AsWord()
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value3));

        RuleListParser = Primitives.And(
            Parsers.Rule.AsWord(),
            Primitives.Optional(
                Parsers.RuleList.AsWord()
            )
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value2.Value));

        MethodParser = Primitives.And(
            Parsers.AnyString.AsWord(),
            Parsers.ParenOpen.AsWord(),
            Parsers.RuleList,
            Parsers.ParenClose.AsWord()
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value3));

        MethodListParser = Primitives.And(
            Parsers.Method.AsWord(),
            Primitives.Optional(
                Parsers.MethodList.AsWord()
            )
        ).Transform(x => ValueNodes.Create(x.Value1, x.Value2.Value));

        {
            RootParserRules = Parsers.MethodList.AsWord();

        }

    }
}
