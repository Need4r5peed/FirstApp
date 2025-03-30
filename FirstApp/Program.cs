using System;
using System.IO;

namespace DriveManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }

            GetCatalogs(); //   Вызов метода получения директорий
            Console.WriteLine();
            NumberOfObjectsInCatalog();
        }

        static void GetCatalogs()
        {
            string dirName = @"C:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
        }

        static void NumberOfObjectsInCatalog()
        {
            try
            {
                string dirName = @"C:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
                if (Directory.Exists(dirName)) // Проверим, что директория существует
                {
                    Console.WriteLine("Количество объектов:");
                    Console.WriteLine(Directory.GetDirectories(dirName).Length + Directory.GetFiles(dirName).Length);
                }
            }
            catch (DirectoryNotFoundException e) { Console.WriteLine($"Ошибка: {e.GetType().Name} - {e.Message} \n(находящейся в {e.StackTrace})"); }
            catch (Exception e) when (e is NotSupportedException || e is ArgumentException) { Console.WriteLine($"Ошибка: {e.GetType().Name} - {e.Message} \n(находящейся в {e.StackTrace})"); }
            catch (Exception e) { Console.WriteLine($"Другая ошибка: {e.Message} \n(находящейся в {e.StackTrace})"); }
            finally { Console.WriteLine("NumberOfObjectsInCatalog закончил работу!"); }
        }
    }
}