using Tyuiu.TatarinovDA.Sprint4.Task5.V25.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task5.V25.Test
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
                {  1, -1, 1, -1, 1 },
                { -1, 1, -1, 1, -1 },
                {  1, -1, 1, -1, 1 },
                { -1, 1, -1, 1, -1 },
                {  1, -1, 1, -1, 1 },
            };
            int expected = 13;
            int actual = ds.Calculate(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
