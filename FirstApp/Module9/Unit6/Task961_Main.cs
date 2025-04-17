using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module9.Unit6.Task961
{
    public class Main_Task961
    {
        /// <summary>
        ///     1) Создание своего класса исключений.
        /// </summary>
        public class MyException_Task961: Exception
        {
            public MyException_Task961():
                base("^___^")
            { }

            public MyException_Task961(string message):
                base(message)
            { }

            public MyException_Task961(string message, Exception innerException): 
                base(message, innerException)
            { }
        }

        public static void Main()
        {
            Console.WriteLine("Hello!");

            /// <summary>
            ///     2) Создание массива исключений "exceptions" из 5 видов исключений + своё.
            /// </summary>
            Exception[] exceptions = new Exception[]
            {
            new MyException_Task961(),
            new ArgumentNullException("Аргумент, передаваемый в метод — null."),
            new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции."),
            new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю."),
            new InvalidOperationException("Вызов метода недопустим в текущем состоянии объекта.")
            };


            /// <summary>
            ///     3) Генерация исключений из массива исключений "exceptions" и их обработка через конструкция try-catch-finally в цикле.
            /// </summary>
            foreach (var exception in exceptions)
            {
                try
                {
                    // Генерируем исключение
                    throw exception;
                }
                catch (MyException_Task961 ex)
                {
                    Console.WriteLine($"Произошло {ex.GetType().Name}: {ex.Message}.");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Произошло {ex.GetType().Name}: {ex.Message}.");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Произошло {ex.GetType().Name}: {ex.Message}.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Произошло {ex.GetType().Name}: {ex.Message}.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Произошло {ex.GetType().Name}: {ex.Message}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошло {ex.GetType().Name}: {ex.Message}.");
                }
                finally
                {
                    Console.WriteLine($"Сработка finally после {exception.GetType().Name}.");
                    Console.WriteLine();
                }
            }
        }
    }
}
