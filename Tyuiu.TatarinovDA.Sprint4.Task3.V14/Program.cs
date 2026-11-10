using Tyuiu.TatarinovDA.Sprint4.Task3.V14.Lib;
// Дан двумерный целочисленный массив 5 на 5 элементов,
// заполненный статическими значениями в диапазоне от 2 до 7.
// Найдите максимальный элемент в четвертой строке массива.

// 3, 2, 3, 3, 5,
// 2, 3, 3, 7, 3,
// 7, 5, 2, 7, 3,
// 4, 2, 7, 5, 2,
// 3, 5, 4, 2, 6,

namespace Tyuiu.TatarinovDA.Sprint4.Task3.V14
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7.                          *");
            Console.WriteLine("* Найдите максимальный элемент в четвертой строке массива.                *");
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 3, 2, 3, 3, 5,                                                          *");
            Console.WriteLine("* 2, 3, 3, 7, 3,                                                          *");
            Console.WriteLine("* 7, 5, 2, 7, 3,                                                          *");
            Console.WriteLine("* 4, 2, 7, 5, 2,                                                          *");
            Console.WriteLine("* 3, 5, 4, 2, 6,                                                          *");
            int[,] array = new int[5, 5]
            {
               {  3, 2, 3, 3, 5, },
               {  2, 3, 3, 7, 3, },
               {  7, 5, 2, 7, 3, },
               {  4, 2, 7, 5, 2, },
               {  3, 5, 4, 2, 6, }
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{array[i, j]} \t");
                }
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int result = ds.Calculate(array);
            Console.WriteLine($" Максимальный элемент в 4-й строке = {result}");


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}