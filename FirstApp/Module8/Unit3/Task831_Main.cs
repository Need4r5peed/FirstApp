using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module8.Unit3.Task831
{
    public class Main_Task831
    {
        public static void Main()
        {
            FileWriter_Task831 File = new FileWriter_Task831();
            //File.AddingListToTextFile();
            File.CreatingFileOrAddingDateAboutLastLaunch();

            //FileReader_Task831 File = new FileReader_Task831();
            //File.OutputsItsSourceCode();

            Console.WriteLine("Программа завершена...");
        }
    }

    class FileWriter_Task831
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

    class FileReader_Task831
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
