using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TatarinovDA.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int max = array[3, 0];
            for (int j = 1; j < 5; j++)
            {
                if (array[3, j] > max)
                {
                    max = array[3, j];
                }
            }
            return max;
        }
    }
}
