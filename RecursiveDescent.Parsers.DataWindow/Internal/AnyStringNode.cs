namespace RecursiveDescent.Parsers.DataWindow; 
internal record AnyStringNode : Node {
    public required string Value { get; init; }
}

internal record ParenOpenNode : RegexNode { }
internal record ParenCloseNode : RegexNode { }
internal record QuoteNode : RegexNode { }
internal record ProducesNode : RegexNode { }
internal record ShortStringNode : RegexNode { }
internal record LongStringNode : RegexNode { }
