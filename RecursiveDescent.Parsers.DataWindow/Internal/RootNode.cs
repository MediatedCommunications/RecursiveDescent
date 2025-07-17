namespace RecursiveDescent.Parsers.DataWindow; 
internal record RootNode : Node {
    public required MethodListNode? Methods { get; init; }
}
