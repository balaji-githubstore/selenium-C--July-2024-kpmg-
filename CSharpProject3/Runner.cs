using KPMG.Area.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject3
{
    public class Runner
    {
        public static void Main(string[] args)
        {

            double outp=Area.AreaOfCircle(3);
            Console.WriteLine(outp);

            Volume obj= new Volume();

            double res= obj.VolumeOfCylinder(10, 2.2);
            Console.WriteLine(res);

            Console.WriteLine(Volume.VolumeOfHemisphere(10));

            string name=Volume.GetAuthorName();
            Console.Write(name);

            Console.WriteLine(Volume.GetAuthorName());

            Console.WriteLine(Math.Max(10,10));

            double resPow=Math.Pow(4,2);
            Console.WriteLine(resPow);

            Console.WriteLine(Math.Sqrt(16));

            Console.WriteLine(obj.GetGreetings());

            Console.WriteLine(Volume.SayHello("bala"));
        }
    }
}
