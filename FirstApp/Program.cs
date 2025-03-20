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
    class Car<T1>
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart)
        { 
        
        }
    }

    class ElectricEngine
    {

    }

    class GasEngine
    {

    }

    class Battery
    { 
    
    }

    class Differential
    { 
    
    }

    class Wheel
    { 
    
    }

    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
