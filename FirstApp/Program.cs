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
    abstract class Car<TEngine> where TEngine: Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar: Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        { 
        
        }
    }

    class GasCar: Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    abstract class Engine
    { 
    
    }

    abstract class CarPart
    {

    }

    class ElectricEngine: Engine
    {

    }

    class GasEngine: Engine
    {

    }

    class Battery: CarPart
    { 
    
    }

    class Differential: CarPart
    { 
    
    }

    class Wheel: CarPart
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
