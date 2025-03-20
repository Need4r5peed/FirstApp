using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    class Obj
    {
        public string Name;
        public string Description;
        public static int MaxValue = 2000;
    }
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
