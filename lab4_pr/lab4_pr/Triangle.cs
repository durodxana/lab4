using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_pr
{
    class Triangle:IGeometry
    {
        private double A, B, C;

        public Triangle(double a, double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double getPerimetr()
        {
            return A+B+C;
        }

        public double getSquare()
        {
            double p=(getPerimetr() / 2);
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
