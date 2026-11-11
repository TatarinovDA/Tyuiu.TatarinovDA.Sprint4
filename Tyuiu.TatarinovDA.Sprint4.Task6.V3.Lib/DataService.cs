using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TatarinovDA.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (string item in array)
            {
                if (item.Length < 6)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
