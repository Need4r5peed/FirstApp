using System;

namespace FirstApp9_1
{
    class Program9_1
    {
        static void Main9_1(string[] args)
        {
            Exception exception = new Exception("Произошло исключение!");

            exception.Data.Add("Дата исключения: ", DateTime.Now);
            exception.HelpLink = "www.skillfactory.ru/";
        }
    }
}