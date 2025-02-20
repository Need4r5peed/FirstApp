using System;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;

            for (int x = 1; x <= 3; x++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                User.Dishes = new string[5];
                Console.WriteLine("Введите три любимых блюда:");
                for (int i = 0; i < User.Dishes.Length; i++)
                {
                    User.Dishes[i] = Console.ReadLine();
                }
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
