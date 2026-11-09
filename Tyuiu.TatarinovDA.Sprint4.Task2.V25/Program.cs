using Tyuiu.TatarinovDA.Sprint4.Task2.V25.Lib;
// Дан одномерный целочисленный массив на 11 элементов заполненный случайными
// в диапазоне от 3 до 9 подсчитать произведение четных элементов массива.
namespace Tyuiu.TatarinovDA.Sprint4.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от 3 до 9 подсчитать произведение     *");
            Console.WriteLine("* четных элементов массива                                                *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Random rnd = new Random();
            int[] array = new int[11];
            Console.WriteLine("* Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(3, 10);
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int result = ds.Calculate(array);
            Console.WriteLine(" Произведение четных элементов = " + result);


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
