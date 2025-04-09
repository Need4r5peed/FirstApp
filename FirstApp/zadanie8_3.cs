using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    class zadanie8_3
    {
        static void Mainzadanie8_3(string[] args)
        {
            FileWriter File = new FileWriter();
            //File.AddingListToTextFile();
            File.CreatingFileOrAddingDateAboutLastLaunch();

            //FileReader File = new FileReader();
            //File.OutputsItsSourceCode();
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

        public void CreatingFileOrAddingDateAboutLastLaunch()
        {
            var fileInfo = new FileInfo(filePath);

            if (!File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath))  // Конструкция Using (будет рассмотрена в последующих юнитах)
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Дмитрий");
                    sw.WriteLine("Иван");
                    sw.WriteLine($"Время последнего запуска файла: {DateTime.Now}");
                }
            }

            if (File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = fileInfo.AppendText())  // Конструкция Using (будет рассмотрена в последующих юнитах)
                {
                    sw.WriteLine($"Время последнего запуска файла: {DateTime.Now}");
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
