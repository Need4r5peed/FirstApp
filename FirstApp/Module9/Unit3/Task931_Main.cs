using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module9.Unit3.Task931
{
    public class Main_Task931
    {
        
        public delegate void DelegateArithmeticOperations_Task931(int a, int b);

        delegate void ShowMessageDelegate_Task931(string _message);

        delegate int RandomNumberDelegate_Task931();

        public static void Main()
        {
            //DelegateArithmeticOperations delegateArithmeticOperations = MinusNumbers;
            //delegateArithmeticOperations -= PlusNumbers;
            //delegateArithmeticOperations.Invoke(100, 200);

            //Action showMessageDelegate = ShowMessage;
            //showMessageDelegate.Invoke();

            //Func<int, int, int, int> sumDelegate = Sum;
            //int result = sumDelegate.Invoke(1, 30, 120);
            //Console.WriteLine(result);

            //Predicate<string> checkLengthDelegate = CheckLength;
            //bool status = checkLengthDelegate.Invoke("skill_factory");
            //Console.WriteLine(status);

            //ShowMessageDelegate showMessageDelegate = delegate (string _message)
            //{
            //    Console.WriteLine(_message);
            //};
            //showMessageDelegate.Invoke("Hello World!");
            //Console.Read();

            //RandomNumberDelegate randomNumberDelegate = delegate()
            //{
            //    return new Random().Next(0, 100);
            //};
            //int result = randomNumberDelegate.Invoke();
            //Console.WriteLine(result);
            //Console.Read();

            //ShowMessageDelegate showMessageDelegate = (string _message) => Console.WriteLine(_message);
            //showMessageDelegate.Invoke("Hello World!");
            //Console.Read();

            RandomNumberDelegate_Task931 randomNumberDelegate = () => new Random().Next(0, 100);

            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();

            Console.WriteLine("Программа завершена...");
        }

        static void MinusNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void PlusNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }
}