using System;

namespace FirstApp9_4
{
    class Program
    {
        public delegate Car HandlerDelegate();

        public delegate void ChildInfoDelegate(Child info);

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }

        public static void ParentInfo(Parent info)
        {
            Console.WriteLine(info.GetType());
        }

        static void Main(string[] args)
        {
            HandlerDelegate handlerDelegate = LexusHandler;

            ChildInfoDelegate childInfoDelegate = ParentInfo;
            childInfoDelegate.Invoke(new Child());
        }
    }

    class Car { }
    class Lexus : Car { }

    class Parent { }
    class Child : Parent { }
}
