namespace RecursiveDescent.Parsers.HStore; 
public static class HStoreParser {

    public static List<KeyValuePair<string, string>>? TryParse(ReadOnlySpan<char> Input) {
        var ret = default(List<KeyValuePair<string, string>>);

        if (Parsers.Root.TryParse(Input).Success is { } Result) {
            ret = [];

            var Rules = Result.Rules;
            while (Rules is { }) {
                if (Rules.Rule is { } Rule) {
                    var Value = KeyValuePair.Create(Rule.Name.Value, Rule.Value.Value);
                    ret.Add(Value);
                }
                Rules = Rules.More;
            }

        }

        return ret;

    }
}
