namespace RecursiveDescent.Parsers.DataWindow; 
internal record MethodListNode : Node {
    public required MethodNode? Method { get; init; }
    public required MethodListNode? More { get; init; }
}
