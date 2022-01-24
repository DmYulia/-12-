using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_статик_класс
{
    static class Circle
    {
        public static double Length(double r)
        {
            return (2*Math.PI*Math.Abs(r));
        }
        public static double Square(double r)
        {
            return (Math.PI*Math.Pow(Math.Abs(r),2));
        }
        public static bool Point(double x, double y, double r, double cx, double cy)
        {
            if (Math.Pow((x-cx),2)+Math.Pow((y-cy),2) <= Math.Pow(r, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
