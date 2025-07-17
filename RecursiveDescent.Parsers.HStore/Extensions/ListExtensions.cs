namespace RecursiveDescent.Parsers.HStore;

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
}