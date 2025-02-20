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
            (string Name, string LastName, string Login, int LoginLength, bool ExistencePet, double Age, string[] FavColors) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();

            //Длинна пароля:
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var AnswerAboutPet = Console.ReadLine();
            if (AnswerAboutPet == "Да")
            {
                User.ExistencePet = true;
            }
            else
            {
                User.ExistencePet = false;
            }

            Console.WriteLine("Введите возраст пользователя");
            User.Age = double.Parse(Console.ReadLine());

            User.FavColors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < User.FavColors.Length; i++)
            {
                User.FavColors[i] = Console.ReadLine();
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
