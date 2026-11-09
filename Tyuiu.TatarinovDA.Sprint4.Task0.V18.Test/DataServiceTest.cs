using Tyuiu.TatarinovDA.Sprint4.Task0.V18.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int expected = 41;
            int actual = ds.GetSumOddArrEl(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
