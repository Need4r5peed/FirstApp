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
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }

    class Vegetables
    {
        public string enName;
        public string ruName;
        public string Color;
    }

    class Fruit: Vegetables
    {
        public string typeFruit;
    }

    class RootVegetables: Vegetables
    {
        public string typeRootVegetables;
    }

    class VarietyFruit : Fruit
    {
        public string nameFruitVariety;
    }

    class VarietyRootVegetables : RootVegetables
    {
        public string nameRootVegetablesVariety;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}