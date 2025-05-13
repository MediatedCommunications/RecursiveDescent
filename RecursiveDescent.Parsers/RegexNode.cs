namespace RecursiveDescent.Parsers; 
public record RegexNode : Node {
    public required string Value { get; init; }
}
