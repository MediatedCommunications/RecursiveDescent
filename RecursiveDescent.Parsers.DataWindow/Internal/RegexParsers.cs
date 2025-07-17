using System.Text.RegularExpressions;

namespace RecursiveDescent.Parsers.DataWindow; 

internal sealed partial class ParenOpenParser() : RegexParser<ParenOpenNode>(GetGeneratedRegex()) {

    [GeneratedRegex(@"^\(", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override ParenOpenNode CreateNode(string Value) {
        return new ParenOpenNode() { Value = Value, };
    }
}

internal sealed partial class ParenCloseParser() : RegexParser<ParenCloseNode>(GetGeneratedRegex()) {

    [GeneratedRegex(@"^\)", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override ParenCloseNode CreateNode(string Value) {
        return new ParenCloseNode() { Value = Value, };
    }
}

internal sealed partial class QuoteParser() : RegexParser<QuoteNode>(GetGeneratedRegex()) {

    [GeneratedRegex(@"^\""", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override QuoteNode CreateNode(string Value) {
        return new QuoteNode() { Value = Value, };
    }
}

internal sealed partial class ProducesParser() : RegexParser<ProducesNode>(GetGeneratedRegex()) {

    [GeneratedRegex(@"^=", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override ProducesNode CreateNode(string Value) {
        return new ProducesNode() { Value = Value, };
    }
}

internal sealed partial class ShortStringParser() : RegexParser<ShortStringNode>(GetGeneratedRegex()) {

    [GeneratedRegex(@"^(\w|\.)+", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override ShortStringNode CreateNode(string Value) {
        return new ShortStringNode() { Value = Value, };
    }
}

internal sealed partial class LongStringParser() : RegexParser<LongStringNode>(GetGeneratedRegex()) {

    //This shoud match anything except for the terminal quote \"
    [GeneratedRegex(@"^(.*?)(?=\"")", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override LongStringNode CreateNode(string Value) {
        return new LongStringNode() { Value = Value, };
    }
}
