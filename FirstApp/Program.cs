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
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        { 
        
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
