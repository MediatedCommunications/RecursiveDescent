

namespace RecursiveDescent.Parsers.HStore {

    internal static partial class Parsers {
        public static CurlyOpenParser CurlyOpen { get; } = new();
        public static CurlyCloseParser CurlyClose { get; } = new();
        public static CommaParser Comma { get; } = new();
        public static QuoteParser Quote { get; } = new();
        public static ProducesParser Produces { get; } = new();
        public static ShortStringParser ShortString { get; } = new();
        public static LongStringParser LongString { get; } = new();

        public static RootParser Root { get; } = new();
        public static RuleListParser RuleList { get; } = new();
        public static RuleParser Rule { get; } = new();
        public static AnyStringParser AnyString { get; } = new();


    }



}
