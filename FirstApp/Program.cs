using System;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileWriter File = new FileWriter();
            //File.AddingListToTextFile();

            FileReader File = new FileReader();
            File.OutputsItsSourceCode();
        }
    }

    class FileWriter
    {
        string filePath = @"C:\Users\Администратор\Trash\SkillFactory\Students.txt"; // Укажем путь

        public void AddingListToTextFile()
        {
            if (!File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath))  // Конструкция Using (будет рассмотрена в последующих юнитах)
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Дмитрий");
                    sw.WriteLine("Иван");
                }
            }
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }
        }
    }

    class FileReader
    { 
        private string filePath = @"D:\VS_Projects\FirstApp\FirstApp\Program.cs";

        public void OutputsItsSourceCode()
        {
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}