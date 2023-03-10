using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.PI * (double)radius * (double)2;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return (double)length * (double)width;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return (double)ground * (double)h * (double)0.5;
        }
    }
}
