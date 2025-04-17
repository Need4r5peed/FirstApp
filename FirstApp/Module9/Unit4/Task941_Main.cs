using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Module9.Unit4.Task941
{
    public class Main_Task941
    {

        public delegate Car_Task941 HandlerDelegate_Task941();

        public delegate void ChildInfoDelegate_Task941(Child_Task941 info);

        public static Car_Task941 CarHandler()
        {
            return null;
        }

        public static Lexus_Task941 LexusHandler()
        {
            return null;
        }

        public static void ParentInfo(Parent_Task941 info)
        {
            Console.WriteLine(info.GetType());
        }

        public static void Main()
        {
            HandlerDelegate_Task941 handlerDelegate = LexusHandler;

            ChildInfoDelegate_Task941 childInfoDelegate = ParentInfo;
            childInfoDelegate.Invoke(new Child_Task941());

            Console.WriteLine("Программа завершена...");
        }
    }

    public class Car_Task941 { }
    public class Lexus_Task941 : Car_Task941 { }

    public class Parent_Task941 { }
    public class Child_Task941 : Parent_Task941 { }
}
