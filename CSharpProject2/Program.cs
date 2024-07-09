

using KPMG.Area.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject2
{
    public class Program
    {


        public static void Main(string[] args)
        {

  

            Console.WriteLine("Enter Radius int value:");
            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(radius);

            //int radius = 10;
            //How to call the static method
            double result = Area.AreaOfCircle(101);
            Console.WriteLine(result);

            double result1 = Area.AreaOfRectangle(10, 10.2);
            Console.WriteLine(result1);

            Console.WriteLine(Area.AreaOfRectangle(10, 34.3));


            double side = Convert.ToDouble(Console.ReadLine());

            double res = Area.AreaOfSquare(side);
            Console.WriteLine("Area of Square " + res);
            Console.ReadLine();


           

        }
    }
}



