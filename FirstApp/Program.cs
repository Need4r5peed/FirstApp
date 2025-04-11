using System;

namespace FirstApp9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException("Произошла ошибка ArgumentOutOfRangeException");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
            Console.WriteLine("Программа закончила работу!");
        }
    }
}
