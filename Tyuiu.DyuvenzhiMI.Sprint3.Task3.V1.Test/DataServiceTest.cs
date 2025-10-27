
using Tyuiu.DyuvenzhiMI.Sprint3.Task3.V1.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'a';
            int res = ds.GetCharCount(value, item);
            Assert.AreEqual(2, res);
        }
    }
}
