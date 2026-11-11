using Tyuiu.TatarinovDA.Sprint4.Task6.V3.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int expected = 4;
            int actual = ds.Calculate(months);  
            Assert.AreEqual(expected, actual);
        }
    }
}
