using System;

namespace FirstApp9_3
{
    class Program
    {
        
        public delegate int DelegateMinus(int a, int b);

        static void Main(string[] args)
        {
            DelegateMinus minusDelegate = MinusNumber;
            int result1 = minusDelegate.Invoke(500, 100);
            Console.WriteLine(result1);

            int result2 = minusDelegate(500, 100);
            Console.WriteLine(result2);
        }

        static int MinusNumber(int a, int b)
        {
            return a - b;
        }

    }
}
