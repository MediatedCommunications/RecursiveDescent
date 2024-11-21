namespace RecursiveDescent.Parsers {

    public static class ValueNodes {
        public static ValueNode Create() {
            return new ValueNode();
        }

        public static ValueNode<TNode1> Create<TNode1>(
            TNode1 Value
            ) {
            return new() {
                Value = Value,
            };
        }

        public static ValueNode<TNode1, TNode2> Create<TNode1, TNode2>(
            TNode1 Value1,
            TNode2 Value2
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
            };
        }

        public static ValueNode<TNode1, TNode2, TNode3> Create<TNode1, TNode2, TNode3>(
            TNode1 Value1,
            TNode2 Value2,
            TNode3 Value3
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
                Value3 = Value3,
            };
        }

        public static ValueNode<TNode1, TNode2, TNode3, TNode4> Create<TNode1, TNode2, TNode3, TNode4>(
            TNode1 Value1,
            TNode2 Value2,
            TNode3 Value3,
            TNode4 Value4
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
                Value3 = Value3,
                Value4 = Value4,
            };
        }

        public static ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5> Create<TNode1, TNode2, TNode3, TNode4, TNode5>(
            TNode1 Value1,
            TNode2 Value2,
            TNode3 Value3,
            TNode4 Value4,
            TNode5 Value5
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
                Value3 = Value3,
                Value4 = Value4,
                Value5 = Value5,
            };
        }

        public static ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6> Create<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6>(
            TNode1 Value1,
            TNode2 Value2,
            TNode3 Value3,
            TNode4 Value4,
            TNode5 Value5,
            TNode6 Value6
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
                Value3 = Value3,
                Value4 = Value4,
                Value5 = Value5,
                Value6 = Value6,
            };
        }

        public static ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7> Create<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7>(
            TNode1 Value1,
            TNode2 Value2,
            TNode3 Value3,
            TNode4 Value4,
            TNode5 Value5,
            TNode6 Value6,
            TNode7 Value7
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
                Value3 = Value3,
                Value4 = Value4,
                Value5 = Value5,
                Value6 = Value6,
                Value7 = Value7,
            };
        }

        public static ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8> Create<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8>(
            TNode1 Value1,
            TNode2 Value2,
            TNode3 Value3,
            TNode4 Value4,
            TNode5 Value5,
            TNode6 Value6,
            TNode7 Value7,
            TNode8 Value8
            ) {
            return new() {
                Value1 = Value1,
                Value2 = Value2,
                Value3 = Value3,
                Value4 = Value4,
                Value5 = Value5,
                Value6 = Value6,
                Value7 = Value7,
                Value8 = Value8,
            };
        }


    }



    public record ValueNode : Node { }

    public record ValueNode<TNode1> : Node {

        public required TNode1 Value { get; init; }

        public void Deconstruct(
            out TNode1 Value1
            ) {
            Value1 = this.Value;
        }
    }

    public record ValueNode<TNode1, TNode2> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
        }
    }

    public record ValueNode<TNode1, TNode2, TNode3> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }
        public required TNode3 Value3 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2,
            out TNode3 Value3
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
            Value3 = this.Value3;
        }
    }

    public record ValueNode<TNode1, TNode2, TNode3, TNode4> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }
        public required TNode3 Value3 { get; init; }
        public required TNode4 Value4 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2,
            out TNode3 Value3,
            out TNode4 Value4
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
            Value3 = this.Value3;
            Value4 = this.Value4;
        }

    }

    public record ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }
        public required TNode3 Value3 { get; init; }
        public required TNode4 Value4 { get; init; }
        public required TNode5 Value5 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2,
            out TNode3 Value3,
            out TNode4 Value4,
            out TNode5 Value5
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
            Value3 = this.Value3;
            Value4 = this.Value4;
            Value5 = this.Value5;
        }
    }


    public record ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }
        public required TNode3 Value3 { get; init; }
        public required TNode4 Value4 { get; init; }
        public required TNode5 Value5 { get; init; }
        public required TNode6 Value6 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2,
            out TNode3 Value3,
            out TNode4 Value4,
            out TNode5 Value5,
            out TNode6 Value6
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
            Value3 = this.Value3;
            Value4 = this.Value4;
            Value5 = this.Value5;
            Value6 = this.Value6;
        }

    }

    public record ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }
        public required TNode3 Value3 { get; init; }
        public required TNode4 Value4 { get; init; }
        public required TNode5 Value5 { get; init; }
        public required TNode6 Value6 { get; init; }
        public required TNode7 Value7 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2,
            out TNode3 Value3,
            out TNode4 Value4,
            out TNode5 Value5,
            out TNode6 Value6,
            out TNode7 Value7
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
            Value3 = this.Value3;
            Value4 = this.Value4;
            Value5 = this.Value5;
            Value6 = this.Value6;
            Value7 = this.Value7;
        }

    }


    public record ValueNode<TNode1, TNode2, TNode3, TNode4, TNode5, TNode6, TNode7, TNode8> : Node {

        public required TNode1 Value1 { get; init; }
        public required TNode2 Value2 { get; init; }
        public required TNode3 Value3 { get; init; }
        public required TNode4 Value4 { get; init; }
        public required TNode5 Value5 { get; init; }
        public required TNode6 Value6 { get; init; }
        public required TNode7 Value7 { get; init; }
        public required TNode8 Value8 { get; init; }

        public void Deconstruct(
            out TNode1 Value1,
            out TNode2 Value2,
            out TNode3 Value3,
            out TNode4 Value4,
            out TNode5 Value5,
            out TNode6 Value6,
            out TNode7 Value7,
            out TNode8 Value8
            ) {

            Value1 = this.Value1;
            Value2 = this.Value2;
            Value3 = this.Value3;
            Value4 = this.Value4;
            Value5 = this.Value5;
            Value6 = this.Value6;
            Value7 = this.Value7;
            Value8 = this.Value8;
        }
    }


}
