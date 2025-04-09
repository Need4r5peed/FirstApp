using System;

namespace FirstApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Произошло исключение!");

            exception.Data.Add("Дата исключения: ", DateTime.Now);
            exception.HelpLink = "www.skillfactory.ru/";
        }
    }
}