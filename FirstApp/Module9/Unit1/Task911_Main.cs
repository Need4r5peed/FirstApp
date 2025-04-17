using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module9.Unit1.Task911
{
    public class Main_Task911
    {
        public static void Main()
        {
            Exception exception = new Exception("Произошло исключение!");

            exception.Data.Add("Дата исключения: ", DateTime.Now);
            exception.HelpLink = "www.skillfactory.ru/";

            Console.WriteLine("Программа завершена...");
        }
    }
}

