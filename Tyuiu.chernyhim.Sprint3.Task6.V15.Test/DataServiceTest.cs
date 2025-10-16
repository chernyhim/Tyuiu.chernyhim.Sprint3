using Tyuiu.chernyhim.Sprint3.Task6.V15.Lib;
namespace Tyuiu.chernyhim.Sprint3.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumTheDivisors(6, 6), 12);
        }
    }
}
