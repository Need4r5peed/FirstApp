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

    class Bus
    {
        public int? Load;

        public void PrintStatusOne()
        {
            if (Load == null || Load == 0)
            {
                Console.WriteLine("Автобус пуст");
            }
            else
            {
                Console.WriteLine($"В автобусе {Load} пассажиров");
            }
        }

        //из подсказки
        public void PrintStatusTwo()
        {
            if (Load.HasValue && Load > 0)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }

    /// <summary>
    /// Класс, описывающий геометрическую фигуру - треугольник.
    /// </summary>
    class Triangle
    {
        public int sideA;
        public int sideB;
        public int sideC;

        static double PerimeterFigure(int sideA, int sideB, int sideC)
        {
            double perimeter = sideA + sideB + sideC;
            return perimeter;
        }

        static double AreaFigure(int sideA, int sideB, int sideC)
        {
            double semiPerimeter = PerimeterFigure(sideA, sideB, sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }
    }

    class TrafficLight
    {
        private void ChangeColor(string color)
        { 
        
        }

        public string GetColor()
        {
            return color;
        }
    }


    /// <summary>
    /// Класс, описывающий геометрическую фигуру - круг.
    /// </summary>
    class Circle
    {
        public int sideR;

        static double PerimeterFigure(int sideR)
        {
            double perimeter = 2 * Math.PI * sideR;
            return perimeter;
        }

        static double AreaFigure(int sideR)
        {
            double area = (PerimeterFigure(sideR) / 2 * sideR) ;
            return area;
        }
    }

    /// <summary>
    /// Класс, описывающий геометрическую фигуру - квадрат.
    /// </summary>
    class Square
    {
        public int sideA;

        static double PerimeterFigure(int sideA)
        {
            double perimeter = sideA * 4;
            return perimeter;
        }

        static double AreaFigure(int sideA)
        {
            double area = sideA * sideA;
            return area;
        }
    }

    class User
    {
        private int age;
        private string login;
        private string email1;
        private string email2;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен состоять миним из 3-х символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        public string Email1
        {
            get
            {
                return email1;
            }

            set
            {
                int a = 0;
                foreach (char symbol in value)
                {
                    if (symbol == '@')
                    {
                        a++;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine("В названии почты отсутствует @");
                }
                else
                {
                    email1 = value;
                }
            }
        }

        public string Email2
        {
            get
            {
                return email2;
            }

            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Неверный формат адреса электронной почты");
                }
                else
                {
                    email2 = value;
                }
            }
        }
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
            return;
        }
    }
}