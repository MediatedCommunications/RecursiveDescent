namespace RecursiveDescent.Parsers; 
public static class IParserExtensions {

    public static ParserResult<TNode> DefaultResult<TNode>(this IParser<TNode> This, ReadOnlySpan<char> Context) where TNode : Node {
        var ret = new ParserResult<TNode>() {
            Context = Context,
            Success = default,
        };

        return ret;
    }

    public static WordParser<TNode> AsWord<TNode>(this IParser<TNode> This) where TNode : Node {
        var ret = new WordParser<TNode>(This);

        return ret;
    }

    public static OptionalParser<TNode> IsOptional<TNode>(this IParser<TNode> This) where TNode : Node {
        var ret = Primitives.Optional(This);

        return ret;
    }

    public static TransformParser<TInput, TOutput> Transform<TInput, TOutput>(this IParser<TInput> This, Func<TInput, TOutput> Transform) where TInput : Node where TOutput : Node {
        var ret = Primitives.Transform(This, Transform);

        return ret;
    }


}
