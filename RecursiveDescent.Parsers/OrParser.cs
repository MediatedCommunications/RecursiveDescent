

using System.Collections.Immutable;

namespace RecursiveDescent.Parsers {
    public readonly struct OrParser<TNode> : IParser<TNode>
    where TNode : Node {

        public OrParser(IEnumerable<IParser<TNode>> Parsers) {
            this.Parsers = [.. Parsers];
        }

        public ImmutableArray<IParser<TNode>> Parsers { get; init; }

        public ParserResult<TNode> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);


            foreach (var Parser in Parsers) {
                if (ret.Success is null
                    && Parser.TryParse(Context0) is { Success: { }, } Success
                    ) {

                    ret = Success;
                    break;

                }

            }

            return ret;
        }
    }

}
