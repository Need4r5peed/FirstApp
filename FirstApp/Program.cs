using System;
using System.Xml.Linq;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = 5.0 / 2;
            double result2 = 5.0 % 2;
            Console.WriteLine("5.0 / 2 = {0}", result1);
            Console.WriteLine("5.0 % 2.0 = {0}", result2);

            double result3 = 10 % 3;
            Console.WriteLine("10 % 3 = {0}", result3);
        }
    }
}
