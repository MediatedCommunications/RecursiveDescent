namespace RecursiveDescent.Parsers.HStore; 
public static class HStoreParser {

    public static List<KeyValuePair<string, string>>? TryParse(ReadOnlySpan<char> Input) {
        var ret = default(List<KeyValuePair<string, string>>);

        if (Parsers.Root.TryParse(Input).Success is { } Result) {
            ret = [];

            foreach(var Rule in Result.Rules) {
                var tret = KeyValuePair.Create(Rule.Name.Value, Rule.Value.Value);
                ret.Add(tret);
            }

        }

        return ret;

    }
}
