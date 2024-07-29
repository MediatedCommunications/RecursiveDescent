namespace RecursiveDescent.Parsers {
    public record OptionalNode<TNode> : Node where TNode : Node {
        public required TNode? Value { get; init; }

        public void Deconstruct(out TNode? Value) {
            Value = this.Value;
        }
    }
}
