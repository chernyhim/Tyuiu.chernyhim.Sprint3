using Tyuiu.chernyhim.Sprint3.Task2.V23.Lib;
namespace Tyuiu.chernyhim.Sprint3.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSeries(1, 1, 1), 1.052);
        }
    }
}
