using Tyuiu.TatarinovDA.Sprint4.Task2.V25.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 6 };
            int res = ds.Calculate(array);
            int wait = 4608;
            Assert.AreEqual(wait, res);
        }
    }
}
