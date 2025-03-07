using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int Rec)
        {
            a = Rec;
            b = Rec;
        }

        public Rectangle(int aRec, int bRec)
        {
            a = aRec;
            b = bRec;
        }

        public int Square()
        {
            return a * b;
        }
    }
    
    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Чёрный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine($"У банка {department?.Company?.Name ?? "Неизвестная компания"} есть отделение в Санкт-Петербурге");
            }
        }

        static Department GetCurrentDepartment()
        {
            // logic
            Department One = ;
            return Department One;
        }
    }
}