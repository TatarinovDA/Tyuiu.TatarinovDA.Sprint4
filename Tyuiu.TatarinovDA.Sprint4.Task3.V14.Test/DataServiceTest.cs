using Tyuiu.TatarinovDA.Sprint4.Task3.V14.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]
            {
               {  3, 2, 3, 3, 5, },
               {  2, 3, 3, 7, 3, },
               {  7, 5, 2, 7, 3, },
               {  4, 2, 7, 5, 2, },
               {  3, 5, 4, 2, 6, }
            };
            int expected = 7;
            int actual = ds.Calculate(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
