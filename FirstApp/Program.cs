using System;

namespace FirstApp9_3
{
    class Program
    {
        
        public delegate void DelegateArithmeticOperations(int a, int b);

        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);

        static void Main(string[] args)
        {
            //DelegateArithmeticOperations delegateArithmeticOperations = MinusNumbers;
            //delegateArithmeticOperations -= PlusNumbers;
            //delegateArithmeticOperations.Invoke(100, 200);

            ShowMessageDelegate showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            SumDelegate sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            CheckLengthDelegate checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);
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
