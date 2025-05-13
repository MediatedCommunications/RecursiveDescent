using System.Text.RegularExpressions;

namespace RecursiveDescent.Parsers; 
public sealed partial class WhiteSpaceParser() : RegexParser<WhiteSpaceNode>(GetGeneratedRegex()) {

    [GeneratedRegex(@"\s*", RegexOptions.IgnoreCase)]
    private static partial Regex GetGeneratedRegex();

    protected override WhiteSpaceNode CreateNode(string Value) {
        return new WhiteSpaceNode() { Value = Value, };
    }
}
