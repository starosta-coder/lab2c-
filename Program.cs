using System;

namespace ConsoleApp2
{
    class Triangle
    {
        private double a, b, c;
        private double P;
        private double S;


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (isTriangle() == true)
            {
                S = Math.Sqrt(P * (P - a) * (P - c) * (P - b));
                P = a + b + c;
            }
        }

        public bool isTriangle()
        {
            if (((a + b > c) && (b + c > a) && (c + a > b)))
                return true;
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine("1 сторона {0}", a);
            Console.WriteLine("2 сторона {0}", b);
            Console.WriteLine("3 сторона {0}", c);

        }
        public double getPerimetr()
        {
            return P;
        }
        public double getSquare()
        {
            return S;
        }
        public void Degree()
        {
            double A = Math.Acos(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double B = Math.Acos(Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
            double C = Math.Acos(Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
            Console.WriteLine("Угол B {0}", B);
            Console.WriteLine("Угол C {0}", C);
            Console.WriteLine("Угол А {0}", A);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(10, 20, 13);
            Console.WriteLine(tr.isTriangle());
            tr.ShowInfo();
            tr.getPerimetr();
            tr.getSquare();
            tr.Degree();

            int k = 3;
            Triangle[] triangles = new Triangle[k];
            Random r = new Random();
            double square = 0;
            int realTriangles = 0;

            for (int i = 0; i < k;)
            {
                triangles[i] = new Triangle(r.NextDouble() * 10, r.NextDouble() * 10, r.NextDouble() * 10);
                Console.WriteLine(triangles[i].ToString());
                if (triangles[i].isTriangle() == true)
                {
                    square += triangles[i].getSquare();
                    realTriangles++;
                    i++;
                }
            }
            Console.WriteLine("Average square of " + realTriangles + " triangles is: " + square / realTriangles);
        }
    }
}