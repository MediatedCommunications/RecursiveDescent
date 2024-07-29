using System.Diagnostics;

namespace RecursiveDescent.Parsers {
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public readonly ref struct ParserResult<TNode> where TNode : Node {
        public required ReadOnlySpan<char> Context { get; init; }
        public required TNode? Success { get; init; }

        private readonly string GetDebuggerDisplay() {
            return $@"Success: {Success is { }}";
        }
    }

}
