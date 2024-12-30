

namespace RecursiveDescent.Parsers {
    public static partial class Primitives {
        public static OptionalParser<TNode> Optional<TNode>(IParser<TNode> This) where TNode : Node {
            var ret = new OptionalParser<TNode>(This);

            return ret;
        }
    }


}
