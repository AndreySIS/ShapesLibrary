using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle : IShape
    {
        public double r { get; set; }
        public Circle() { }
        public Circle(double r)
        {
            this.r = r;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
