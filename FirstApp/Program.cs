using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    internal class Program
    {
        static string ShowColor(string username, int age)
        {
            Console.WriteLine($"{username}({age} лет),{Environment.NewLine}Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        static int[] GetArrayFromConsole() // Добавление по одному элементу в массив, вместимостью в 5 интовых элементов, сортировка элементов массива по возрастанию и вывод массива в отсортированном виде на консоль
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int w = 0;
            while (w != -1 * (result.Length - 1))
            {
                w = 0;
                for (int i = 0; i <= result.Length - 2; i++)
                {
                    int a = result[i];
                    int b = result[i + 1];
                    if (result[i] > result[i + 1])
                    {
                        result[i] = b;
                        result[i + 1] = a;
                        w++;
                    }
                    else
                    {
                        w--;
                    }
                }
            }
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }

            return result;
        }

        static int[] GetArrayFromConsoleOnly(ref int num) // должен читать введенные с клавиатуры массивы и возвращать их
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] result) // должен принимать параметром массив array типа данных int, сортировать его и возвращать
        {
            int w = 0;
            while (w != -1 * (result.Length - 1))
            {
                w = 0;
                for (int i = 0; i <= result.Length - 2; i++)
                {
                    int a = result[i];
                    int b = result[i + 1];
                    if (result[i] > result[i + 1])
                    {
                        result[i] = b;
                        result[i + 1] = a;
                        w++;
                    }
                    else
                    {
                        w--;
                    }
                }
            }
            //foreach (var number in result)
            //{
            //    Console.Write(number + " ");
            //}

            return result;
        }

        static void ShowArray(int[] arrayShow, bool boolSortAttribute = false)
        {
            int[] resultArrayShow = arrayShow;

            if (boolSortAttribute == true)
            {
                resultArrayShow = SortArray(arrayShow);
            }
            foreach (var number in resultArrayShow)
            {
                Console.Write(number + " ");
            }
        }

        static void GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void ChangeName(ref string age)
        {
            Console.WriteLine("Введите имя");
            age = Console.ReadLine();
        }

        static void GetAge(int age)
        {
            Console.WriteLine("Введите свой возраст");
            age = Int32.Parse(Console.ReadLine());
        }

        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите свой возраст");
            age = Int32.Parse(Console.ReadLine());
        }

        static void BigDataOperationV1(int[] arr)
        {
            arr[0] = 4;
        }

        static void BigDataOperationV2(ref int[] arr)
        {
            arr[0] = 4;
        }

        static void BigDataOperationV3(in int[] arr)
        {
            arr[0] = 4;
        }

        static void BigDataOperationV4(int[] arr, int data)
        {
            data = 4;

            arr[0] = data;
        }

        static void BigDataOperationV5(int[] arr, ref int data)
        {
            data = 4;

            arr[0] = data;
        }

        static void BigDataOperationV6(ref int[] arr, int data)
        {
            data = 4;

            arr[0] = data;
        }

        static void BigDataOperationV7(ref int[] arr, ref int data)
        {
            data = 4;

            arr[0] = data;
        }

        static void BigDataOperationV8(in int[] arr, int data)
        {
            data = 4;

            arr[0] = data;
        }

        static void BigDataOperationV9(in int[] arr, ref int data)
        {
            data = 4;

            arr[0] = data;
        }

        public static void Main(string[] args)
        {

            //var (name, age) = ("Евгения", 27);

            //Console.WriteLine("Мое имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите возрас с цифрами:");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            ///

            //(string name, int age) anketa;

            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //var favcolors = new string[3];

            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    favcolors[i] = ShowColor(name, age);
            //}

            //Console.WriteLine("Ваши любимые цвета:");
            //foreach (var color in favcolors)
            //{
            //    Console.WriteLine(color);
            //}

            //Задание 5.2.15
            //var array = GetArrayFromConsoleOnly(3);
            //var sortedarray = SortArray(array);

            //var array2 = GetArrayFromConsoleOnly(10);
            //ShowArray(array2, true);

            //var someName = "Leo";
            //Console.WriteLine(someName);

            //var someAge = 18;
            //Console.WriteLine(someAge);

            //GetAge(someAge);
            //Console.WriteLine(someAge);

            //GetName(someName);
            //Console.WriteLine(someName);

            //ChangeAge(ref someAge);
            //Console.WriteLine(someAge);

            //ChangeName(ref someName);
            //Console.WriteLine(someName);

            var arr = new int[] { 1, 2, 3 };
            var data = 5;

            //BigDataOperationV1(arr);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV2(ref arr);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV3(arr);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV4(arr, data);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV5(arr, ref data);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV6(ref arr, data);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV7(ref arr, ref data);
            //Console.WriteLine(arr[0]);

            //BigDataOperationV8(arr, data);
            //Console.WriteLine(arr[0]);

            BigDataOperationV9(arr, ref data);
            Console.WriteLine(arr[0]);
        }
    }
}