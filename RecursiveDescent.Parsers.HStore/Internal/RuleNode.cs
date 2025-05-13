namespace RecursiveDescent.Parsers.HStore; 
internal record RuleNode : Node {
    public required AnyStringNode Name { get; init; }
    public required AnyStringNode Value { get; init; }
}
