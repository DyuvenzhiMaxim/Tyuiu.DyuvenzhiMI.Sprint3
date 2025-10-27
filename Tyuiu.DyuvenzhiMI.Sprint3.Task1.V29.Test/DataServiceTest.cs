
using Tyuiu.DyuvenzhiMI.Sprint3.Task1.V29.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int StartValue = 1;
            int StopValue = 11;
            double res = ds.GetMultiplySeries(value, StartValue, StopValue);
            double wait = 2872.986;
            Assert.AreEqual(wait, res);
        }
    }
}
