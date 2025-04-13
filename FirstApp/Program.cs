using System;

namespace FirstApp9_4
{
    class Program
    {
        public delegate Car HandlerDelegate();

        static Car CarHandler()
        {
            return null;
        }


        static Lexus LexusHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            HandlerDelegate handlerDelegate = LexusHandler;
        }
    }

    class Car { }
    class Lexus : Car { }
}
