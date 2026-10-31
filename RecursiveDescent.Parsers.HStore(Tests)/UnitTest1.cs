namespace RecursiveDescent.Parsers.HStore.Tests; 
[TestClass]
public class UnitTest1 {

    [TestMethod]
    public void BiggerTest() {
        var Input = """"  {"date_to"=>"03/03/2019", "date_from"=>"03/03/2019", "occupation"=>"Homemaker ", "current_employer"=>"true"} """";
        var ret = HStoreParser.TryParse(Input)?.ToDictionary();

        Assert.IsNotNull(ret);
    }

    [TestMethod]
    public void SimpleTest() {
        var Input = """"  {"key1"=>"value1",    key2    =>    value2   }  """";

        var ret = HStoreParser.TryParse(Input)?.ToDictionary();

        Assert.IsNotNull(ret);

        ret.TryGetValue("key1", out var value1);
        ret.TryGetValue("key2", out var value2);

        Assert.AreEqual("value1", value1);
        Assert.AreEqual("value2", value2);

    }

    [TestMethod]
    public void InnerString() {

        var Input = """"  { "Inner\"Quote" => "Inner\"Quote" }  """";

        var ret = HStoreParser.TryParse(Input)?.ToDictionary();

        Assert.IsNotNull(ret);

        var Text = "Inner\"Quote";

        ret.TryGetValue(Text, out var value1);

        Assert.AreEqual(Text, value1);

    }

    [TestMethod]
    public void UnclosedQuote() {
        var Input = """"  { "Unclosed" => " }  """";

        Assert.IsNull(HStoreParser.TryParse(Input));
    }

    [TestMethod]
    public void RejectsIncompleteInput() {
        Assert.IsNull(HStoreParser.TryParse("!!!"));
        Assert.IsNull(HStoreParser.TryParse("\"key1\"=>\"value1\" junk"));
        Assert.IsNull(HStoreParser.TryParse("\"key1\"=>\"value1\" \"key2\"=>\"value2\""));
        Assert.IsNull(HStoreParser.TryParse("\"key1\"=>\"value1\","));
        Assert.IsNull(HStoreParser.TryParse("{ \"key1\"=>\"value1\", }"));
        Assert.IsNull(HStoreParser.TryParse("{"));
    }

    [TestMethod]
    public void TrailingBackslash() {
        var ret = HStoreParser.TryParse("""{"k"=>"a\\", "path"=>"C:\\", "two"=>"a\\\\"}""")?.ToDictionary();

        Assert.IsNotNull(ret);
        Assert.AreEqual("a\\", ret["k"]);
        Assert.AreEqual("C:\\", ret["path"]);
        Assert.AreEqual("a\\\\", ret["two"]);
    }

    [TestMethod]
    public void EscapedQuote() {
        var ret = HStoreParser.TryParse("""{"k"=>"a\"b"}""")?.ToDictionary();

        Assert.IsNotNull(ret);
        Assert.AreEqual("a\"b", ret["k"]);
    }

    [TestMethod]
    public void QuotedEmptyValue() {
        var ret = HStoreParser.TryParse("""{"a"=>""}""")?.ToDictionary();

        Assert.IsNotNull(ret);
        Assert.AreEqual(string.Empty, ret["a"]);
    }

    [TestMethod]
    public void NullWord() {
        var quoted = HStoreParser.TryParse("""{"a"=>NULL, "b"=>"x"}""")?.ToDictionary();
        var bare = HStoreParser.TryParse("""a=>null""")?.ToDictionary();

        Assert.IsNotNull(quoted);
        Assert.AreEqual("NULL", quoted["a"]);
        Assert.AreEqual("x", quoted["b"]);
        Assert.IsNotNull(bare);
        Assert.AreEqual("null", bare["a"]);
    }

    [TestMethod]
    public void LongList() {
        var input = string.Join(", ", Enumerable.Range(0, 1000).Select(i => $"k{i}=>v{i}"));
        var ret = HStoreParser.TryParse(input);

        Assert.IsNotNull(ret);
        Assert.AreEqual(1000, ret.Count);
        Assert.AreEqual("k0", ret[0].Key);
        Assert.AreEqual("v0", ret[0].Value);
        Assert.AreEqual("k999", ret[^1].Key);
        Assert.AreEqual("v999", ret[^1].Value);
    }

    [TestMethod]
    public void EmptyString() {
        var Input = """"  """";

        var ret = HStoreParser.TryParse(Input)?.ToDictionary();

        Assert.IsNotNull(ret);
        Assert.AreEqual(0, ret.Count);


    }

    [TestMethod]
    public void BraceString() {
        var Input = """" { } """";

        var ret = HStoreParser.TryParse(Input)?.ToDictionary();

        Assert.IsNotNull(ret);
        Assert.AreEqual(ret.Count, 0);


    }


    [TestMethod]
    public void SqlTest() {

        var DbName = "LEGACY_Docketwise_TestDb4";
        DbName = "Docketwise-12-9-24-Panchal";

        var C = new Microsoft.Data.SqlClient.SqlConnection($@"Server=(local);Database={DbName};TrustServerCertificate=True;Integrated Security=true;");
        C.Open();

        var Queries = new List<string>() {
            "select settings as Data from Contacts",
            "select Data as Data from Contacts",
            "select cq_person_settings as Data from Contacts",
            "select cq_company_settings as Data from Contacts",
        };

        foreach (var Query in Queries) {
            using var Q = new Microsoft.Data.SqlClient.SqlCommand(Query, C);
            using var R = Q.ExecuteReader();
            while (R.Read()) {
                if (R["data"] is string { } Input) {
                    var ret = HStoreParser.TryParse(Input)?.ToDictionary();

                    if (ret is null) {

                    }

                }
            }
        }
    }

}