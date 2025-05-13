using System.Text.RegularExpressions;

namespace RecursiveDescent.Parsers; 
internal static class ReadOnlySpanExtensions {


    public static ParserResult<TNode> MoveNext<TNode>(this ReadOnlySpan<char> This, TNode Node, ValueMatch Match) where TNode : Node {
        return This.MoveNext(Node, Match.Length);
    }

    public static ParserResult<TNode> MoveNext<TNode>(this ReadOnlySpan<char> This, TNode Node, int Length) where TNode : Node {
        var ret = new ParserResult<TNode>() {
            Success = Node,
            Context = This[Length..],
        };
        return ret;
    }

}
