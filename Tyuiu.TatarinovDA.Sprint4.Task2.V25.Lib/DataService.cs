using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TatarinovDA.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    product *= array[i];
                    hasEven = true;
                }
            }
            return hasEven ? product : 0;
        }
        public int[] GenerateRandomArray(int length, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }
    }
}
