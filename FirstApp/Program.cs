using System;

namespace FirstApp9_3
{
    class Program
    {
        
        public delegate int DelegateMinus(int a, int b);

        static void Main(string[] args)
        {
            DelegateMinus minusDelegate = MinusNumber;
            int result = minusDelegate.Invoke(500, 100);
            Console.WriteLine(result);
        }

        static int MinusNumber(int a, int b)
        {
            return a - b;
        }

    }
}
