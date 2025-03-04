using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    internal class Program
    {
        /// <summary>
        /// Метод-анкета. Возвращает готовую анкету в виде кортежа, полученную после опроса пользователя. Выполнено по Заданию 5.6.
        /// </summary>
        /// <returns></returns>
        static (string, string, int, bool, int, string[], bool, int, string[]) UserDataEntry()
        {
            (string Name, string LastName, int Age, bool Pet, int countPet, string[] petNames, bool Colors, int numberColors, string[] favoriteColors) verifiableUser;

            //verifiableUser = ("", "", 0, false, 0);
            //1. Имя
            Console.WriteLine("Введите ваше Имя:");
            verifiableUser.Name = CheckingTexString(Console.ReadLine());

            //2. Второе имя
            Console.WriteLine("Введите вашу фамилию:");
            verifiableUser.LastName = CheckingTexString(Console.ReadLine());

            //3. Возраст
            Console.WriteLine("Введите ваш возраст:");
            verifiableUser.Age = CheckingNumberInt(Console.ReadLine());

            //4. Наличие питомца
            Console.WriteLine("Есть ли у вас питомец:");
            verifiableUser.Pet = PetsExistence(CheckingTexString(Console.ReadLine()));

            //5. Количество питомцев
            verifiableUser.countPet = 0;
            if (verifiableUser.Pet == true)
            {
                Console.WriteLine("Введите количество питомцев:");
                verifiableUser.countPet = CheckingNumberInt(Console.ReadLine());
            }

            //6. Имена питомцев
            verifiableUser.petNames = new string[verifiableUser.countPet];
            if (verifiableUser.countPet > 0)
            {
                verifiableUser.petNames = InputPetNames(verifiableUser.countPet);
            }

            //7.0 Наличие любимого цвета (Добавлен самостоятельно - для логики 0 в следующих пунктах)
            Console.WriteLine("Есть ли у вас любимый цвет:");
            verifiableUser.Colors = ColorsExistence(CheckingTexString(Console.ReadLine()));

            //7.1 Количество любимых цветов
            verifiableUser.numberColors = 0;
            if (verifiableUser.Colors == true)
            {
                Console.WriteLine("Введите количество любимых цветов:");
                verifiableUser.numberColors = CheckingNumberInt(Console.ReadLine());
            }

            //8. 
            verifiableUser.favoriteColors = new string[verifiableUser.numberColors];
            if (verifiableUser.numberColors > 0)
            {
                verifiableUser.favoriteColors = InputColors(verifiableUser.numberColors);
            }

            //verifiableUser = (verifiableUser.Name, verifiableUser.LastName, verifiableUser.Age, verifiableUser.Pet, verifiableUser.countPet);

            return verifiableUser;
        }

        /// <summary>
        /// Метод, размечающий пункты анкеты при её выводе на консоль.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static string PointsOfProfile(int value)
        {
            switch (value + 1)
            {
                case 1: return "Имя пользователя:";
                case 2: return "Фамилия пользователя:";
                case 3: return "Возраст пользователя:";
                case 4: return "Наличие животных у пользователя:";
                case 5: return "Количество животных пользователя:";
                case 6: return "Клички животных пользователя:";
                case 7: return "Наличие любимых цветов у пользователя:";
                case 8: return "Количество любимых цветов пользователя:";
                case 9: return "Любимые цвета пользователя:";
                default: return "Такого пункта в данной анкете нет!";
            }
        }

        /// <summary>
        /// Метод, собирающий любимые цвета пользователя, перечисляемые им попорядку, в одномерный массив. Метод возвращает собранный массив.
        /// </summary>
        /// <param name="numberColors"></param>
        /// <returns></returns>
        static string[] InputColors(int numberColors)
        {
            string[] inputColors = new string[numberColors];

            for (int i = 0; i < numberColors; i++)
            {
                Console.WriteLine("Введите {0}-й любимый цвет:", (i + 1));
                inputColors[i] = CheckingTexString(Console.ReadLine());
            }

            return inputColors;
        }

        /// <summary>
        /// Метод, который проверяет ответ пользователя о наличии у него питомца. Исходя из ответа - возвращает bool.
        /// </summary>
        /// <param name="Colors"></param>
        /// <returns></returns>
        static bool ColorsExistence(string Colors)
        {
            switch (Colors)
            {
                case "Да": case "да": case "Yes": case "yes":
                    return true;
                case "Нет": case "нет": case "No": case "no":
                    return false;
                default:
                    Console.WriteLine("Некорректный текст ввода. Ответьте на последний вопрос повторно:");
                    return ColorsExistence(CheckingTexString(Console.ReadLine()));
            }
        }

        /// <summary>
        /// Метод, собирающий в массив клички питомцев пользователя, перечисляемые им попорядку. Возвращает собранный массив.
        /// </summary>
        /// <param name="countPet"></param>
        /// <returns></returns>
        static string[] InputPetNames(int countPet)
        {
            string[] petNames = new string[countPet];

            for (int i = 0;i < countPet; i++ )
            {
                Console.WriteLine("Введите кличку {0}-го питомца:", (i + 1));
                petNames[i] = CheckingTexString(Console.ReadLine());
            }

            return petNames;
        }

        /// <summary>
        /// Проверяет ответ - о наличии питомца. Если ответ некорректный - просит ввести ответ заново. Если верный - возвращает bool.
        /// </summary>
        /// <param name="Pet"></param>
        /// <returns></returns>
        static bool PetsExistence(string Pet)
        {
            switch (Pet)
            {
                case "да": case "yes": case "д": case "y":
                    return true;
                case "нет": case "no": case "н": case "n":
                    return false;
                default:
                    Console.WriteLine("Некорректный текст ввода. Ответьте на последний вопрос повторно:");
                    return PetsExistence(CheckingTexString(Console.ReadLine()));
            }
        }
        /// <summary>
        /// Проверяет - не является ли введённое значение пустым, является ли оно числом, а также - больше нуля или нет. Если нет - то просит ввести число повторно. Возвращает только интовое число больше 0.
        /// </summary>
        /// <param name="numberInt"></param>
        /// <returns></returns>
        static int CheckingNumberInt(string numberInt)
        {
            // Проверяем, является ли ввод пустой строкой или нечисловым значением
            if (string.IsNullOrWhiteSpace(numberInt) || !int.TryParse(numberInt, out int checkNumber))
            {
                Console.WriteLine("Некорректный ввод (введён текст или пустая строка). Ответьте на последний вопрос повторно:");
                return CheckingNumberInt(Console.ReadLine()); 
            }

            // Проверяем, что число больше 0
            if (checkNumber <= 0)
            {
                Console.WriteLine("Некорректный числовой ввод (число должно быть больше 0). Ответьте на последний вопрос повторно:");
                return CheckingNumberInt(Console.ReadLine()); 
            }

            return checkNumber; 
        }

        /// <summary>
        /// Проверяет текст на вшивость
        /// </summary>
        /// <param name="textString"></param>
        /// <returns></returns>
        static string CheckingTexString(string textString)
        {
            if (string.IsNullOrWhiteSpace(textString) || int.TryParse(textString, out _))
            {
                Console.WriteLine("Некорректный ввод (введено число или пустая строка). Ответьте на последний вопрос повторно:");
                return CheckingTexString(Console.ReadLine());
            }

            return textString;
        }

        /// <summary>
        /// Метод выводит анкету-кортеж на консоль
        /// </summary>
        /// <param name="tuple"></param>
        static void PrintTuple(ITuple tuple)
        {
            Console.WriteLine("Анкета:");
            for (int i = 0; i < tuple.Length; i++)
            {
                if (tuple[i] is int || tuple[i] is bool || tuple[i] is string)
                {
                    Console.WriteLine($"{i + 1}. {PointsOfProfile(i)}: {tuple[i]}");
                }
                else if (tuple[i] is Array)
                {
                    Console.WriteLine($"{i + 1}. {PointsOfProfile(i)}:");
                    PrintArray(i + 1, (string[])tuple[i]);
                }
            }

            static void PrintArray(int i, string[] array)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine($"{i}.{j + 1}. {array[j]}");
                }
            }
        }

        public static void Main(string[] args)
        {
            var tuple = UserDataEntry();
            PrintTuple(tuple);
        }
    }
}