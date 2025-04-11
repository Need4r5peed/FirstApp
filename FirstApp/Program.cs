using System;

namespace FirstApp9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Произошла ошибка RankException");
            }
            catch(Exception ex) when (ex is RankException)
            {
                Console.WriteLine(ex.GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine();
            }
            Console.WriteLine("Программа закончила работу!");
        }
    }
}
