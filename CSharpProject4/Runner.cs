using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject4
{
    public class Runner
    {
        public static int aS = 10;  //static variable or class variable
        public static int bS = 20;

        public int aNS = 10;  //non-static variable or instance variable
        public int bNS = 20;

        public static void Main(string[] args)
        {
            int aS = 10; 
            Console.WriteLine(aS);

            Runner.aS = 1000;
            Console.WriteLine(Runner.aS);
            Console.WriteLine(Runner.bS);


            Runner obj1=new Runner(); //1st instance of class
            Console.WriteLine(obj1.GetHashCode());
            obj1.aNS = 1000;

            Runner obj2=new Runner(); //2nd instance of class
            Console.WriteLine(obj2.GetHashCode());

            obj2 = obj1;
            obj2.aNS = 50;

            //obj1 = null;

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);

            Console.WriteLine(obj2.aNS);
            Console.WriteLine(obj2.bNS);

           
        }
    }
}
