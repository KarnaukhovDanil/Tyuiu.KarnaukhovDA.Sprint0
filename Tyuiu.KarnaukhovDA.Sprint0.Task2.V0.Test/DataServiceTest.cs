using Tyuiu.KarnaukhovDA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint0.Task2.V0.Test;


[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Даниил";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Даниил", res);
    }
} 

