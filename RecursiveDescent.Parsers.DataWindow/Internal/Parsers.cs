

namespace RecursiveDescent.Parsers.DataWindow; 

internal static partial class Parsers {
    public static ParenOpenParser ParenOpen { get; } = new();
    public static ParenCloseParser ParenClose { get; } = new();
    public static QuoteParser Quote { get; } = new();
    public static ProducesParser Produces { get; } = new();
    public static ShortStringParser ShortString { get; } = new();
    public static LongStringParser LongString { get; } = new();

    public static RootParser Root { get; } = new();

    public static MethodListParser MethodList { get; } = new();
    public static MethodParser Method { get; } = new();

    public static RuleListParser RuleList { get; } = new();
    public static RuleParser Rule { get; } = new();
    public static AnyStringParser AnyString { get; } = new();


}
