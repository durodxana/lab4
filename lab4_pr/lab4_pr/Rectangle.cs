using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_pr
{
    class Rectangle:IGeometry
    {

        private double X, Y;

        public Rectangle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double getPerimetr()
        {
            return (X+ Y)*2;
        }


        public double getSquare()
        {
            return X*Y;
        }
    }
}
