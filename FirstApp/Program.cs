using System;

namespace FirstApp9_3
{
    class Program
    {
        
        public delegate void DelegateArithmeticOperations(int a, int b);

        static void Main(string[] args)
        {
            DelegateArithmeticOperations delegateArithmeticOperations = MinusNumbers;
            delegateArithmeticOperations += PlusNumbers;
            delegateArithmeticOperations.Invoke(100, 200);
        }

        static void MinusNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void PlusNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
