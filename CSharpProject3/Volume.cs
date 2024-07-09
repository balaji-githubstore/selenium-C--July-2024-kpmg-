using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject3
{
    public class Volume
    {
        public double VolumeOfCylinder(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

        public static double VolumeOfHemisphere(double radius)
        {
            double a = (2 * Math.PI * radius * radius * radius) / 3;
            
            return a;
        }

        public static string GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public string GetGreetings()
        {
            return "Hello";
        }

        public static string SayHello(string name)
        {
            return "Hello "+name;
        }


    }
}