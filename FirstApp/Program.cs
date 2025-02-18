using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("while ...");

            //int k = 0;

            //while (true)
            //{
            //    Console.WriteLine(k);

            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //    var color = Console.ReadLine();

            //    if (color == "stop")
            //    {
            //        Console.WriteLine("Цикл остановлен");
            //        break;
            //    }

            //    switch (color)
            //    {
            //        case "red":
            //        case "Red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //        case "Green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //        case "Cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }

            //    k++;
            //}

            Console.WriteLine("Введите своё имя:");

            string youName = Console.ReadLine();

            string reverseName = "";

            Console.WriteLine("Ваше обратное имя по буквам:");

            foreach (var nameSimbol in youName)
            {
                reverseName = nameSimbol + reverseName;
            }
            foreach (var nameSimbol in reverseName)
            {
                Console.Write(nameSimbol + " ");
            }
            Console.Write("Последняя буква вашего обратного имени: {0}", reverseName[reverseName.Length - 1]);
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
