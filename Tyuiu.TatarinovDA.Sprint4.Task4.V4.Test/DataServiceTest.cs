using Tyuiu.TatarinovDA.Sprint4.Task4.V4.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task4.V4.Test
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
               { 5, 9, 6, 8, 5, },
               { 6, 6, 7, 3, 8, },
               { 4, 3, 9, 8, 7, },
               { 3, 3, 6, 7, 7, },
               { 8, 3, 8, 6, 6, }
            };
            int[,] expected = new int[5, 5]
            {
               { 5, 9, 1, 1, 5, },
               { 1, 1, 7, 3, 1, },
               { 1, 3, 9, 1, 7, },
               { 3, 3, 1, 7, 7, },
               { 1, 3, 1, 1, 1, }
            };
            int[,] actual = ds.Calculate(array);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j], $"Ошибка в элементе [{i},{j}]");
                }
            }
        }
    }
}
