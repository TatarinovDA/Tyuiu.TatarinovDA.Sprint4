using Tyuiu.TatarinovDA.Sprint4.Task4.V4.Lib;
// Дан двумерный целочисленный массив 5 на 5 элементов,
// заполненный значениями с клавиатуры в диапазоне от 3 до 9. Заменить четные элементы массива на 1.
// 5, 9, 6, 8, 5,
// 6, 6, 7, 3, 8,
// 4, 3, 9, 8, 7,
// 3, 3, 6, 7, 7,
// 8, 3, 8, 6, 6,
namespace Tyuiu.TatarinovDA.Sprint4.Task4.V4
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 9. Заменить четные элементы *");
            Console.WriteLine("* Массива на 1.                                                           *");
            int[,] matrix = new int[5, 5];
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                            *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int inputValue;
                    while (true)
                    {
                        Console.Write($" Введите значение для элемента [{i},{j}] (от 3 до 9): ");
                        string str = Console.ReadLine();
                        if (int.TryParse(str, out inputValue) && inputValue >= 3 && inputValue <= 9)
                        {
                            matrix[i, j] = inputValue;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите целое число в диапазоне от 3 до 9.");
                        }
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] res = ds.Calculate(matrix);
            
            
            
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ (четные замены на 1):                                         *");
            Console.WriteLine("***************************************************************************");
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}