using System.ComponentModel.DataAnnotations;
using Tyuiu.chernyhim.Sprint3.Task7.V19.Lib;
namespace Tyuiu.chernyhim.Sprint3.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            int len = stopvalue - startvalue + 1;
            double[] valueWait;
            valueWait =new double[len];

            valueWait[0] = 23.612;
            valueWait[1] = 16.077;
            valueWait[2] = 7.838;
            valueWait[3] = 4.578;
            valueWait[4] = Math.Round(2.87983, 3);
            valueWait[5] = 0.75;
            valueWait[6] = -4.474;
            valueWait[7] = -9.461;
            valueWait[8] = -7.414;
            valueWait[9] = -6.162;
            valueWait[10] = -7.294;
            CollectionAssert.AreEqual(ds.GetMassFunction(-5,5),valueWait);
        }
    }
}
