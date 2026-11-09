using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TatarinovDA.Sprint4.Task0.V18.Lib
{
    public class DataService : ISprint4Task0V18
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item %2 != 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}
