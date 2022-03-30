using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Triangle : IShape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string CheckRightTriangle()
        {
            if (Math.Round(c, 2) == Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2))
                return "Right triangle";
            else
                return "Non-right triangle";
        }
    }
}
