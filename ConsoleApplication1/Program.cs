using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
        double side1;
        double side2;
        double side3;
 
        public double a{
            get { return side1; }
            set { side1 = value; }
        }

        public double b
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double c
        {
            get { return side3; }
            set { side3 = value; }
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public bool IsTriangle()
        {
            if (((this.a + this.b) > this.c) && ((this.b + this.c) > this.a) && ((this.a + this.c) > this.b))
                return true;
            else
            {
                Console.WriteLine("Это не треугольник!");
                return false;
            }
        }
    }

    class STriangle : Triangle
    {
        double[] katet = new double[2];

        public STriangle(double a, double b, double c) : base(a, b, c) { }


        bool Pifagor(double x, double y, double z)
        {
            return (x * x + y * y == z * z) ? true : false;
        }

        void PutKatet(double a, double b)
        {
            katet[0] = a;
            katet[1] = b;
        }
        public bool IsRectangular()
        {
            if (!IsTriangle())
            {
                return false;
            }
            if (Pifagor(a, b, c))
            {
                PutKatet(a, b);
                return true;
            }
            else if (Pifagor(a, c, b))
            {
                PutKatet(a, c);
                return true;
            }
            else if (Pifagor(c, b, a))
            {
                PutKatet(c, b);
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным.");
                return false;
            }
        }

        public double Area()
        {
            return (katet[0] * katet[1]) / 2;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            STriangle ob = new STriangle(7, 24, 25);
            Console.WriteLine(ob.a + " " + ob.b + " " + ob.c);
            if (ob.IsRectangular())
            {
                double area = ob.Area();
                Console.WriteLine("Площадь прямоугольного треугольника равна: " + area);

            }
            Console.ReadLine();
        }
    }
}
