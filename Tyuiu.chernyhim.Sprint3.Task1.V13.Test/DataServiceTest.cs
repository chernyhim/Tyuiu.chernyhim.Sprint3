using Tyuiu.chernyhim.Sprint3.Task1.V13.Lib;
namespace Tyuiu.chernyhim.Sprint3.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1, ds.GetMultiplySeries(1, 1, 1));
        }
    }
}
