namespace RecursiveDescent.Parsers.HStore {
    internal record AnyStringNode : Node {
        public required string Value { get; init; }
    }

    internal record CurlyOpenNode : RegexNode { }
    internal record CurlyCloseNode : RegexNode { }
    internal record CommaNode : RegexNode { }
    internal record QuoteNode : RegexNode { }
    internal record ProducesNode : RegexNode { }
    internal record ShortStringNode : RegexNode { }
    internal record LongStringNode : RegexNode { }
}
