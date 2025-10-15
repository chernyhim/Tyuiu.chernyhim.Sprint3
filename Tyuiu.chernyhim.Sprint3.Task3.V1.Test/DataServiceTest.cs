using Tyuiu.chernyhim.Sprint3.Task3.V1.Lib;
namespace Tyuiu.chernyhim.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2, ds.GetCharCount("have a nive time", 'a'));
        }
    }
}
