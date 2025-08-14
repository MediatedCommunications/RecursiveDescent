using RecursiveDescent.Parsers.DataWindow;

namespace RecursiveDescent.Parsers.DataWindow.Tests; 
[TestClass]
public class UnitTest1 {

    [TestMethod]
    public void SimpleTest() {
        var Input = $@"column(name=integer1 age=23 other=\""a\"")";

        var ret = DataWindowParser.TryParse(Input);
        
        Assert.IsNotNull(ret);
        
        var First = ret.FirstOrDefault();
        
        Assert.IsNotNull(First);

        First.Arguments.TryGetValue("name", out var value1);
        First.Arguments.TryGetValue("age", out var value2);

        Assert.AreEqual("integer1", value1);
        Assert.AreEqual("23", value2);

    }

    [TestMethod]
    public void FileTest() {
        var Input = System.IO.File.ReadAllText($@"C:\TEMP\DataWindow.txt");
        var ret = DataWindowParser.TryParse(Input);

    }

   



}