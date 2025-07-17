namespace RecursiveDescent.Parsers.DataWindow;

internal static class ListExtensions {
    public static IEnumerator<RuleNode> GetEnumerator(this RuleListNode? This) {
        var Input = This;

        while(Input is { }) {
            
            if(Input.Rule is { } ret) {
                yield return ret;
            }

            Input = Input.More;

        }
    }

    public static IEnumerator<MethodNode> GetEnumerator(this MethodListNode? This) {
        var Input = This;

        while (Input is { }) {

            if (Input.Method is { } ret)
            {
                yield return ret;
            }

            Input = Input.More;

        }
    }
}