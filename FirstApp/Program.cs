using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите своё имя:");

            //string youName = Console.ReadLine();

            //string reverseName = "";

            //Console.WriteLine("Ваше имя по буквам:");

            //foreach (var nameSimbol in youName)
            //{
            //    reverseName = nameSimbol + reverseName;
            //}
            ////foreach (var nameSimbol in reverseName)
            ////{
            ////    Console.Write(nameSimbol + " ");
            ////}
            //for (int i = reverseName.Length - 1; i >= 0 ; i--)
            //{
            //    Console.Write(reverseName[i] + " ");
            //}
            //Console.Write("Последняя буква вашего обратного имени: {0}", reverseName[0]);

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            Console.WriteLine("Массив: { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } }");

            Console.WriteLine();
            Console.WriteLine("Перепор по строкам:");
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Перепор по столбцам:");
            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            Console.WriteLine();
            Console.WriteLine("Массив: { 5, 6, 9, 1, 2, 3, 4 }");

            Console.WriteLine();
            Console.WriteLine("Сортировка интовых элементов одномерного массива в порядке возрастания:");
            var arrItog = new int[arr.Length];

            int w = 0;
            while (w != -1 * (arr.Length - 1))
            {
                w = 0;
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    int a = arr[i];
                    int b = arr[i + 1];
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = b;
                        arr[i + 1] = a;
                        w++;
                    }
                    else
                    {
                        w--;
                    }
                }
            }
            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var arrSum = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            Console.WriteLine();
            Console.WriteLine("Массив: { 5, 6, 9, 1, 2, 3, 4 }");

            Console.WriteLine();
            Console.WriteLine("Сумма всех элементов массива:");
            int sum = 0;
            for (int i = 0; i <= arrSum.Length - 1; i++)
            {
                sum = sum + arrSum[i];
            }
            Console.WriteLine(sum);
        }

        enum Day : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sanday
        }
    }
}
