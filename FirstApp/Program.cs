using System;

namespace FirstApp9_3
{
    class Program
    {
        
        public delegate void DelegateArithmeticOperations(int a, int b);

        delegate void ShowMessageDelegate(string _message);

        delegate int RandomNumberDelegate();

        static void Main(string[] args)
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

            RandomNumberDelegate randomNumberDelegate = delegate()
            {
                return new Random().Next(0, 100);
            };
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }

        static int RandomNumber()
        {
            return new Random().Next(0, 100);
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
