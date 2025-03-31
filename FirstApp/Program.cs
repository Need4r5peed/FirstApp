using System;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                Action numberOfObjectsText = null;
                Action NumberOfObjects = null;

                string dirName = @"C:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);

                if (dirInfo.Exists)
                {
                    numberOfObjectsText = () => Console.WriteLine("Количество объектов:");
                    NumberOfObjects = () => Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                    numberOfObjectsText();
                    NumberOfObjects();
                }

                string newDirName = @"C:\\SkillFactory_Task";
                string newFolderName = "NewFolder";

                DirectoryInfo newDirInfo = new DirectoryInfo(newDirName);
                if (!newDirInfo.Exists)
                {
                    newDirInfo.Create();

                    newDirInfo.CreateSubdirectory(newFolderName);
                }

                if (numberOfObjectsText != null && NumberOfObjects != null)
                {
                    numberOfObjectsText(); 
                    NumberOfObjects();   
                }

                string oldDirName = @"C:\\SkillFactory_Task";

                DirectoryInfo oldDirInfo = new DirectoryInfo(oldDirName);
                if (oldDirInfo.Exists)
                {
                    oldDirInfo.Delete(true);
                }

                if (numberOfObjectsText != null && NumberOfObjects != null)
                {
                    numberOfObjectsText();
                    NumberOfObjects();
                }
            }
            catch (DirectoryNotFoundException e) { Console.WriteLine($"Ошибка: {e.GetType().Name} - {e.Message} \n(находящейся в {e.StackTrace})"); }
            catch (Exception e) when (e is NotSupportedException || e is ArgumentException) { Console.WriteLine($"Ошибка: {e.GetType().Name} - {e.Message} \n(находящейся в {e.StackTrace})"); }
            catch (Exception e) { Console.WriteLine($"Другая ошибка: {e.Message} \n(находящейся в {e.StackTrace})"); }
            finally { Console.WriteLine("NumberOfObjectsInCatalog закончил работу!"); }
        }

        DirectoryInfo dirInfo = new DirectoryInfo(@"/" /* Или С:\\ для Windows */ );
    }
}