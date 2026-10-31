namespace RecursiveDescent.Parsers.DataWindow.Tests; 
[TestClass]
public class UnitTest1 {

    [TestMethod]
    public void SimpleTest() {
        var Input = """column(name=integer1 age=23 other="a\"b")""";

        var ret = DataWindowParser.TryParse(Input);

        Assert.IsNotNull(ret);

        var First = ret.FirstOrDefault();

        Assert.IsNotNull(First);

        First.Arguments.TryGetValue("name", out var value1);
        First.Arguments.TryGetValue("age", out var value2);
        First.Arguments.TryGetValue("other", out var value3);

        Assert.AreEqual("integer1", value1);
        Assert.AreEqual("23", value2);
        Assert.AreEqual("a\"b", value3);

    }

    [TestMethod]
    public void RejectsIncompleteInput() {
        Assert.IsNull(DataWindowParser.TryParse("!!!"));
        Assert.IsNull(DataWindowParser.TryParse("column(name=a) !!!"));
        Assert.IsNull(DataWindowParser.TryParse("column(other=\")"));
        Assert.IsNull(DataWindowParser.TryParse("column(name=a other=\")"));
        Assert.IsNull(DataWindowParser.TryParse("column()"));
        Assert.IsNull(DataWindowParser.TryParse("column(x=-1)"));
    }

    [TestMethod]
    public void EmptyInput() {
        var ret = DataWindowParser.TryParse("   \n");

        Assert.IsNotNull(ret);
        Assert.AreEqual(0, ret.Count);
    }

    [TestMethod]
    public void EscapesAndNewlines() {
        var escaped = DataWindowParser.TryParse("""column(name=a other="a\\" name2="a\" name=c") header(height="1\"2")""");

        Assert.IsNotNull(escaped);
        Assert.AreEqual(2, escaped.Count);
        Assert.AreEqual("a\\", escaped[0].Arguments["other"]);
        Assert.AreEqual("a\" name=c", escaped[0].Arguments["name2"]);
        Assert.AreEqual("1\"2", escaped[1].Arguments["height"]);

        var newline = DataWindowParser.TryParse("column(name=\"hello\nworld\")");

        Assert.IsNotNull(newline);
        Assert.AreEqual("hello\nworld", newline[0].Arguments["name"]);
    }

    [TestMethod]
    public void DottedNames() {
        var ret = DataWindowParser.TryParse("""column(edit.limit=0 font.face="Tahoma")""");

        Assert.IsNotNull(ret);
        Assert.AreEqual("0", ret[0].Arguments["edit.limit"]);
        Assert.AreEqual("Tahoma", ret[0].Arguments["font.face"]);
    }

    [TestMethod]
    public void LongList() {
        var arguments = string.Join(" ", Enumerable.Range(0, 1000).Select(i => $"a{i}=b{i}"));
        var byArgument = DataWindowParser.TryParse($"column({arguments})");

        Assert.IsNotNull(byArgument);
        Assert.AreEqual(1000, byArgument[0].Arguments.Count);
        Assert.AreEqual("b0", byArgument[0].Arguments["a0"]);
        Assert.AreEqual("b999", byArgument[0].Arguments["a999"]);

        var methods = string.Join(" ", Enumerable.Range(0, 1000).Select(i => $"m{i}(a=b)"));
        var byMethod = DataWindowParser.TryParse(methods);

        Assert.IsNotNull(byMethod);
        Assert.AreEqual(1000, byMethod.Count);
        Assert.AreEqual("m0", byMethod[0].Name);
        Assert.AreEqual("m999", byMethod[^1].Name);
    }

    [TestMethod]
    public void FileTest() {
        var Input = System.IO.File.ReadAllText($@"C:\TEMP\DataWindow.txt");
        var ret = DataWindowParser.TryParse(Input);

    }

   



}