using Tyuiu.TatarinovDA.Sprint4.Task7.V30.Lib;
namespace Tyuiu.TatarinovDA.Sprint4.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "684259137159648";
            int res = ds.Calculate(5,3,value);
            int wait = 73728;
            Assert.AreEqual(wait,res);
        }
    }
}
