using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceProject
{
    public class Father
    {
        public int FAge = 60;

        public Father(int FAge)
        {
            this.FAge = FAge;
            Console.WriteLine("Father Constructor");
        }

        public void FatherStyle()
        {
            Console.WriteLine("Father Style w!!");
        }
    }
    class Son : Father
    {

        public int sAge = 20;

        public Son(int FAge, int sAge):base(FAge)
        {
            this.sAge = sAge;
            Console.WriteLine("Son Constructor");
        }

        public void SonStyle()
        {
            Console.WriteLine("Son style");
        }
    }

    public class Runner
    {

        static void Main(string[] args)
        {
            //Father father = new Father();
            //Console.WriteLine(father.FAge);
            //father.FatherStyle();

            Son obj = new Son(65,25);
            Console.WriteLine(obj.FAge);
            Console.WriteLine(obj.sAge);
            obj.FatherStyle();
            obj.SonStyle();

        }
    }
}
