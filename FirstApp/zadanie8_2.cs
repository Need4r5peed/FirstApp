using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp8_2
{
    class zadanie8_2
    {
        static void zadanie8_2_Main(string[] args)
        {
            //// получим системные диски
            //DriveInfo[] drives = DriveInfo.GetDrives();

            //// Пробежимся по дискам и выведем их свойства
            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine($"Название: {drive.Name}");
            //    Console.WriteLine($"Тип: {drive.DriveType}");
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine($"Объем: {drive.TotalSize}");
            //        Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
            //        Console.WriteLine($"Метка: {drive.VolumeLabel}");
            //    }
            //}

            //GetCatalogs(); //   Вызов метода получения директорий
            //Console.WriteLine();
            //NumberOfObjectsInCatalog();


            string FolderName = @"C:\Users\Администратор\Desktop\testFolder";
            DirectoryInfo folderInfo = new DirectoryInfo(FolderName);
            if (!folderInfo.Exists)
            {
                folderInfo.Create();
                Console.WriteLine(folderInfo.FullName);
            }

            MoveFolderToTrash(folderInfo.FullName);

        }

        static void MoveFolderToTrash(string FullNameDir)
        {
            try
            {
                string FolderName = FullNameDir;
                string BasketName = @"C:\Users\Администратор\Trash\testFolder";
                Console.WriteLine(FolderName);
                Console.WriteLine(BasketName);

                //DirectoryInfo dirInfo = new DirectoryInfo(FolderName);
                if (Directory.Exists(FolderName))
                {
                    Console.WriteLine($"Папка {FolderName} существует.");
                }
                else
                {
                    Console.WriteLine($"Папка {FolderName} не существует.");
                }
                if (Directory.Exists(BasketName))
                {
                    Console.WriteLine($"Папка {BasketName} существует.");
                }
                else
                {
                    Console.WriteLine($"Папка {BasketName} не существует.");
                }
                if (Directory.Exists(FolderName) /*&& Directory.Exists(BasketName)*/)
                {
                    Directory.Move(FolderName, BasketName);
                    Console.WriteLine($"Папка {FolderName} перемещена в Basket.");
                }
            }
            catch (DirectoryNotFoundException e) { Console.WriteLine($"Ошибка: {e.GetType().Name} - {e.Message} \n(находящейся в {e.StackTrace})"); }
            catch (Exception e) when (e is NotSupportedException || e is ArgumentException) { Console.WriteLine($"Ошибка: {e.GetType().Name} - {e.Message} \n(находящейся в {e.StackTrace})"); }
            catch (Exception e) { Console.WriteLine($"Другая ошибка: {e.Message} \n(находящейся в {e.StackTrace})"); }
            finally
            {
                Console.WriteLine("MoveFolderToTrash закончила работу");
            }
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
