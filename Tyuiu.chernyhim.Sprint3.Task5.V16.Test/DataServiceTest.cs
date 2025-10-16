using Tyuiu.chernyhim.Sprint3.Task5.V16.Lib;
namespace Tyuiu.chernyhim.Sprint3.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSumSeries(2, 1, 1, 1, 1), 4.540);
        }
    }
}
