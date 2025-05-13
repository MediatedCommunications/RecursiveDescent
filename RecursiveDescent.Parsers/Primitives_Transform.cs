

namespace RecursiveDescent.Parsers; 
public static partial class Primitives {
    public static TransformParser<TInput, TOutput> Transform<TInput, TOutput>(IParser<TInput> Input, Func<TInput, TOutput> Transform) where TInput : Node where TOutput : Node {
        var ret = new TransformParser<TInput, TOutput>(Input, Transform);

        return ret;
    }
}
