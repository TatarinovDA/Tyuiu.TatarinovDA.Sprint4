using Tyuiu.TatarinovDA.Sprint4.Task1.V5.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int expected = 60;
            int actual = ds.Calculate(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
