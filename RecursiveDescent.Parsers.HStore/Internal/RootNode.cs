namespace RecursiveDescent.Parsers.HStore {
    internal record RootNode : Node {
        public required RuleListNode? Rules { get; init; }
    }
}
