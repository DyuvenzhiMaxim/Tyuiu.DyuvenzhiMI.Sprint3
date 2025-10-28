
using Tyuiu.DyuvenzhiMI.Sprint3.Task7.V18.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[] { 7.76, 7.36, 7.26, 7.9, 15.88, 2.0, 4.35, 5.63, 6.49, 6.49, 6.32, };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
