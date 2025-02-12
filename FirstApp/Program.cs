using System;
using System.Xml.Linq;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day of week?: ");
            Day day = checked((Day)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your favorite day is {0} ", day);

            //Console.Write("Введите имя: ");
            //var name1 = Console.ReadLine();
            //Console.Write("Введите ваш возраст: ");
            //var age1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите вашу дату рождения: ");
            //var birthdate = Console.ReadLine();

            Console.ReadKey();
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
