using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_pr
{
    class Circle:IGeometry
    {
        double R;
        public Circle(double r)
        {
            R=r;
        }

        public double getPerimetr()
        {
            return 2*R*Math.PI;
        }

        public double getSquare()
        {
            return Math.PI*R*R;
        }

    }
}
