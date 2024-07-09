using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.Area.Formulae
{
    public class Area
    {
         static double AreaOfCircle(int r)
        {
            return Math.PI * r * r;
        }
        //public static double AreaOfCircle(double r)
        //{
        //    return Math.PI * r * r;
        //}

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        //create a method for AreaOfTriangle
        public static double AreaOfTriangle(double baseValue, double height)
        {
            return (baseValue * height) / 2;
        }

        //Create a method for AreaOfSquare
        public static double AreaOfSquare(double side)
        {
            return side * side;
        }

    }
}
