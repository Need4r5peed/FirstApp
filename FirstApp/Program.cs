using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Введите вид питомца: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Введите возраст питомца: ");
            Pet.Age = Convert.ToInt32(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
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
