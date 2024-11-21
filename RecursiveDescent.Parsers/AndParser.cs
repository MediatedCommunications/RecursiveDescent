namespace RecursiveDescent.Parsers {

    public readonly struct AndParser<TNode1, TNode2> : IParser<ValueNode<TNode1, TNode2>>
        where TNode1 : Node
        where TNode2 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }

                    ) {

                    ret = new() {
                        Context = Context2,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                        },
                    };

                }
            }


            return ret;
        }
    }

    public readonly struct AndParser<TNode1, TNode2, TNode3> : IParser<ValueNode<TNode1, TNode2, TNode3>>
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }
        public required IParser<TNode3> Parser3 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2, TNode3>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }
                    && Parser3.TryParse(Context2) is { Success: { } Value3, Context: var Context3 }

                    ) {

                    ret = new() {
                        Context = Context3,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                            Value3 = Value3,
                        },
                    };

                }
            }


            return ret;
        }
    }

    public readonly struct AndParser<TNode1, TNode2, TNode3, TNode4> : IParser<ValueNode<TNode1, TNode2, TNode3, TNode4>>
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }
        public required IParser<TNode3> Parser3 { get; init; }
        public required IParser<TNode4> Parser4 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2, TNode3, TNode4>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }
                    && Parser3.TryParse(Context2) is { Success: { } Value3, Context: var Context3 }
                    && Parser4.TryParse(Context3) is { Success: { } Value4, Context: var Context4 }

                    ) {

                    ret = new() {
                        Context = Context4,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                            Value3 = Value3,
                            Value4 = Value4,
                        },
                    };

                }
            }


            return ret;
        }
    }

    public readonly struct AndParser<TNode1, TNode2, TNode3, TNode4, TNode5> : IParser<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5>>
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }
        public required IParser<TNode3> Parser3 { get; init; }
        public required IParser<TNode4> Parser4 { get; init; }
        public required IParser<TNode5> Parser5 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }
                    && Parser3.TryParse(Context2) is { Success: { } Value3, Context: var Context3 }
                    && Parser4.TryParse(Context3) is { Success: { } Value4, Context: var Context4 }
                    && Parser5.TryParse(Context4) is { Success: { } Value5, Context: var Context5 }

                    ) {

                    ret = new() {
                        Context = Context5,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                            Value3 = Value3,
                            Value4 = Value4,
                            Value5 = Value5,

                        },
                    };

                }
            }


            return ret;
        }
    }

    public readonly struct AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6> : IParser<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6>>
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node
        where TNode6 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }
        public required IParser<TNode3> Parser3 { get; init; }
        public required IParser<TNode4> Parser4 { get; init; }
        public required IParser<TNode5> Parser5 { get; init; }
        public required IParser<TNode6> Parser6 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }
                    && Parser3.TryParse(Context2) is { Success: { } Value3, Context: var Context3 }
                    && Parser4.TryParse(Context3) is { Success: { } Value4, Context: var Context4 }
                    && Parser5.TryParse(Context4) is { Success: { } Value5, Context: var Context5 }
                    && Parser6.TryParse(Context5) is { Success: { } Value6, Context: var Context6 }

                    ) {

                    ret = new() {
                        Context = Context6,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                            Value3 = Value3,
                            Value4 = Value4,
                            Value5 = Value5,
                            Value6 = Value6,
                        },
                    };

                }
            }


            return ret;
        }
    }

    public readonly struct AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7> : IParser<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7>>
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node
        where TNode6 : Node
        where TNode7 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }
        public required IParser<TNode3> Parser3 { get; init; }
        public required IParser<TNode4> Parser4 { get; init; }
        public required IParser<TNode5> Parser5 { get; init; }
        public required IParser<TNode6> Parser6 { get; init; }
        public required IParser<TNode7> Parser7 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }
                    && Parser3.TryParse(Context2) is { Success: { } Value3, Context: var Context3 }
                    && Parser4.TryParse(Context3) is { Success: { } Value4, Context: var Context4 }
                    && Parser5.TryParse(Context4) is { Success: { } Value5, Context: var Context5 }
                    && Parser6.TryParse(Context5) is { Success: { } Value6, Context: var Context6 }
                    && Parser7.TryParse(Context6) is { Success: { } Value7, Context: var Context7 }

                    ) {

                    ret = new() {
                        Context = Context7,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                            Value3 = Value3,
                            Value4 = Value4,
                            Value5 = Value5,
                            Value6 = Value6,
                            Value7 = Value7,
                        },
                    };

                }
            }


            return ret;
        }
    }

    public readonly struct AndParser<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8> : IParser<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8>>
        where TNode1 : Node
        where TNode2 : Node
        where TNode3 : Node
        where TNode4 : Node
        where TNode5 : Node
        where TNode6 : Node
        where TNode7 : Node
        where TNode8 : Node {

        public required IParser<TNode1> Parser1 { get; init; }
        public required IParser<TNode2> Parser2 { get; init; }
        public required IParser<TNode3> Parser3 { get; init; }
        public required IParser<TNode4> Parser4 { get; init; }
        public required IParser<TNode5> Parser5 { get; init; }
        public required IParser<TNode6> Parser6 { get; init; }
        public required IParser<TNode7> Parser7 { get; init; }
        public required IParser<TNode8> Parser8 { get; init; }

        public ParserResult<ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8>> TryParse(ReadOnlySpan<char> Context0) {
            var ret = this.DefaultResult(Context0);

            {
                if (ret.Success is null

                    && Parser1.TryParse(Context0) is { Success: { } Value1, Context: var Context1 }
                    && Parser2.TryParse(Context1) is { Success: { } Value2, Context: var Context2 }
                    && Parser3.TryParse(Context2) is { Success: { } Value3, Context: var Context3 }
                    && Parser4.TryParse(Context3) is { Success: { } Value4, Context: var Context4 }
                    && Parser5.TryParse(Context4) is { Success: { } Value5, Context: var Context5 }
                    && Parser6.TryParse(Context5) is { Success: { } Value6, Context: var Context6 }
                    && Parser7.TryParse(Context6) is { Success: { } Value7, Context: var Context7 }
                    && Parser8.TryParse(Context7) is { Success: { } Value8, Context: var Context8 }

                    ) {

                    ret = new() {
                        Context = Context8,
                        Success = new() {
                            Value1 = Value1,
                            Value2 = Value2,
                            Value3 = Value3,
                            Value4 = Value4,
                            Value5 = Value5,
                            Value6 = Value6,
                            Value7 = Value7,
                            Value8 = Value8,
                        },
                    };

                }
            }


            return ret;
        }
    }

}
