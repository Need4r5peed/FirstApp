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

            Console.WriteLine();
            Console.WriteLine("Зубчатые массивы:");
            int[][] arrayZub = new int[3][];
            arrayZub[0] = new int[2] { 1, 2 };
            arrayZub[1] = new int[3] { 1, 2, 3 };
            arrayZub[2] = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Массив: { { 1, 2 }, { 1, 2, 3 }, { 1, 2, 3, 4, 5 } }");

            Console.WriteLine();
            Console.WriteLine("Перебор массива:");
            foreach (var elementarrayZub in arrayZub)
            {
                foreach (var item in elementarrayZub)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задача по поиску количества положительных элементов в массиве:");
            var arrSearchPositive = new int[] { 5, 6, -9, 1, 2, -3, 4, 0 };
            Console.WriteLine("Массив: {{ 5, 6, -9, 1, 2, -3, 4, 0 }}");

            Console.WriteLine();
            Console.Write("Количество положительных элементов:");
            int SearchPositive = 0;
            int arrElements = arrSearchPositive.Length - 1;
            while (arrElements != -1)
            {
                if (arrSearchPositive[arrElements] > 0)
                {
                    SearchPositive++;
                }
                arrElements--;
            }
            Console.WriteLine("\t" + SearchPositive);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задача по поиску количества положительных элементов в двумерном массиве:");
            int[,] bivariatearrSearchPositive = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            Console.WriteLine("Массив: { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } }");

            Console.WriteLine();
            Console.Write("Количество положительных элементов:");
            int bSearchPositive = 0;
            for (int i = 0; i < bivariatearrSearchPositive.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < bivariatearrSearchPositive.GetUpperBound(1) + 1; j++)
                {
                    if (bivariatearrSearchPositive[i, j] > 0)
                    {
                        bSearchPositive++;
                    }
                }
            }
            Console.WriteLine("\t" + bSearchPositive);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задача по сортировке элементов по возрастанию в двумерном массиве:");
            int[,] bivariatearrSort = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            Console.WriteLine("Массив: { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } }");

            Console.WriteLine();
            Console.WriteLine("Сортировка по строкам:");
            for (int i = 0; i < bivariatearrSort.GetUpperBound(0) + 1; i++)
            {
                int ww = 0;
                while (ww != -1 * (bivariatearrSort.GetUpperBound(1)))
                {
                    ww = 0;
                    for (int j = 0; j <= bivariatearrSort.GetUpperBound(1) - 1; j++)
                    {
                        int a = bivariatearrSort[i, j];
                        int b = bivariatearrSort[i, j + 1];
                        if (bivariatearrSort[i, j] > bivariatearrSort[i, j + 1])
                        {
                            bivariatearrSort[i, j]  = b;
                            bivariatearrSort[i, j + 1] = a;
                            ww++;
                        }
                        else
                        {
                            ww--;
                        }
                    }
                }
            }
            for (int i = 0; i < bivariatearrSort.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < bivariatearrSort.GetUpperBound(1) + 1; k++)
                    Console.Write(bivariatearrSort[i, k] + " ");

                Console.WriteLine();
            }
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
