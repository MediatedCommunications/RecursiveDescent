namespace RecursiveDescent.Parsers.DataWindow; 
internal record MethodNode : Node {
    public required AnyStringNode Name { get; init; }
    public required RuleListNode Value { get; init; }
}
