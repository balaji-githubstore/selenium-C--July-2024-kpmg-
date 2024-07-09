using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject5Poly
{
    public class CalcRunner
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Add(1, 1);

            cal.Add(2, 2.2);

            Console.WriteLine("bala");
        }
    }
}