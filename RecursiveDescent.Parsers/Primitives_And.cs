

namespace RecursiveDescent.Parsers; 

public static partial class Primitives {

    public static OrParser<TNode> Or<TNode>(IEnumerable<IParser<TNode>> Parsers) where TNode : Node {
        return new OrParser<TNode>(Parsers);
    }

    public static AndParser<TNode1, TNode2> And<TNode1, TNode2>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2
        )
        where TNode1 : Node
        where TNode2 : Node {
        return new AndParser<TNode1, TNode2>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
        };
    }

    public static AndParser<TNode1, TNode2, TNode3> And<TNode1, TNode2, TNode3>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2,
        IParser<TNode3> Parser3
        )
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node {
        return new AndParser<TNode1, TNode2, TNode3>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
            Parser3 = Parser3,
        };
    }

    public static AndParser<TNode1, TNode2, TNode3, TNode4> And<TNode1, TNode2, TNode3, TNode4>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2,
        IParser<TNode3> Parser3,
        IParser<TNode4> Parser4
        )
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node {
        return new AndParser<TNode1, TNode2, TNode3, TNode4>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
            Parser3 = Parser3,
            Parser4 = Parser4,
        };
    }

    public static AndParser<TNode1, TNode2, TNode3, TNode4, TNode5> And<TNode1, TNode2, TNode3, TNode4, TNode5>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2,
        IParser<TNode3> Parser3,
        IParser<TNode4> Parser4,
        IParser<TNode5> Parser5
        )
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node {
        return new AndParser<TNode1, TNode2, TNode3, TNode4, TNode5>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
            Parser3 = Parser3,
            Parser4 = Parser4,
            Parser5 = Parser5,
        };
    }

    public static AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6> And<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2,
        IParser<TNode3> Parser3,
        IParser<TNode4> Parser4,
        IParser<TNode5> Parser5,
        IParser<TNode6> Parser6
        )
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node
        where TNode6 : Node {
        return new AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
            Parser3 = Parser3,
            Parser4 = Parser4,
            Parser5 = Parser5,
            Parser6 = Parser6,
        };
    }

    public static AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7> And<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2,
        IParser<TNode3> Parser3,
        IParser<TNode4> Parser4,
        IParser<TNode5> Parser5,
        IParser<TNode6> Parser6,
        IParser<TNode7> Parser7
        )
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node
        where TNode6 : Node
        where TNode7 : Node {
        return new AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
            Parser3 = Parser3,
            Parser4 = Parser4,
            Parser5 = Parser5,
            Parser6 = Parser6,
            Parser7 = Parser7,
        };
    }

    public static AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8> And<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8>(
        IParser<TNode1> Parser1,
        IParser<TNode2> Parser2,
        IParser<TNode3> Parser3,
        IParser<TNode4> Parser4,
        IParser<TNode5> Parser5,
        IParser<TNode6> Parser6,
        IParser<TNode7> Parser7,
        IParser<TNode8> Parser8
        )
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node
        where TNode6 : Node
        where TNode7 : Node
        where TNode8 : Node {
        return new AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8>() {
            Parser1 = Parser1,
            Parser2 = Parser2,
            Parser3 = Parser3,
            Parser4 = Parser4,
            Parser5 = Parser5,
            Parser6 = Parser6,
            Parser7 = Parser7,
            Parser8 = Parser8,
        };
    }
}
