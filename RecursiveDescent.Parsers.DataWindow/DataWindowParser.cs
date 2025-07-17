using System.Collections.Immutable;

namespace RecursiveDescent.Parsers.DataWindow; 
public static class DataWindowParser {

    public static List<DataWindowMethod>? TryParse(ReadOnlySpan<char> Input) {
        var ret = default(List<DataWindowMethod>);

        if (Parsers.Root.TryParse(Input).Success is { } Result) {
            ret = [];

            foreach (var Method in Result.Methods)
            {
                var Name = Method.Name.Value;

                var Values = new Dictionary<string, string>();
                foreach(var Value in Method.Value)
                {
                    Values[Value.Name.Value] = Value.Value.Value;
                }

                var tret = new DataWindowMethod() {
                    Name = Name,
                    Arguments = Values.ToImmutableDictionary(),
                };

                ret.Add(tret);
            }

        }

        return ret;

    }
}

public record DataWindowMethod {
    public required string Name { get; init; }
    public required ImmutableDictionary<string, string> Arguments { get; init; }
}
