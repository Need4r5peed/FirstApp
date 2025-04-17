using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module9.Unit2.Task921
{
    public class Main_Task921
    {
        public static void Main()
        {
            try
            {
                throw new RankException("Произошла ошибка RankException");
            }
            catch (Exception ex) when (ex is RankException)
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

            Console.WriteLine("Программа завершена...");
        }
    }
}
