using System;
using System.Xml.Linq;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Jane";
            const string MyName = "Jane";
            string mySecondName = "Li";

            Console.WriteLine(myName);
            Console.WriteLine(mySecondName);
            Console.WriteLine("Привет, \n мир");
            Console.WriteLine(MyName);
            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);
            Console.WriteLine(5.5);
            Console.WriteLine("Завершение юнита 3.2. Переменные, константы, литералы");
            Console.ReadKey();
        }
    }
}
