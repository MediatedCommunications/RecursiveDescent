namespace RecursiveDescent.Parsers.HStore {
    internal static class Grammars {
        public static IParser<ValueNode<AnyStringNode, AnyStringNode>> RuleParser { get; }
        public static IParser<ValueNode<RuleNode, RuleListNode>> RuleListParser { get; }
        public static IParser<RuleListNode> RootParserRules { get; }

        static Grammars() {
            RuleParser = Primitives.And(
                Parsers.AnyString.AsWord(),
                Parsers.Produces.AsWord(),
                Parsers.AnyString.AsWord()
            ).Transform(x => ValueNodes.Create(x.Value1, x.Value3));

            RuleListParser = Primitives.And(
                Parsers.Rule.AsWord(),
                Primitives.Optional(
                    Primitives.And(
                        Parsers.Comma.AsWord(),
                        Parsers.RuleList.AsWord()
                    )
                )
            ).Transform(x => ValueNodes.Create(x.Value1, x.Value2.Value?.Value2));

            {
                RootParserRules = Primitives.Or([
                    Parsers.RuleList.AsWord(),

                    Primitives.And(
                        Parsers.CurlyOpen.AsWord(),
                        Parsers.RuleList.AsWord(),
                        Parsers.CurlyClose.AsWord()
                        ).Transform(x => x.Value2),
                ]);

            }

        }
    }






}
