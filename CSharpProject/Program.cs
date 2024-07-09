using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.CSharpProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(2/3.0);

            Console.WriteLine("Hello World!!!");

            Console.WriteLine("Balaji Dinakaran");

            //print your company name. 
            //Console.WriteLine("KPMG Company!!");

            int a = 11;  //4Bytes or 32 bits utilized during runtime
            int b = 2;  //64 bits

            double c = a + b;  //64 Bits, 32 bits--> outcomes will be 64bits

            //declare variable d and do subtraction and print d 
            double d = a - b; //32 bits

            //declare variable e and do multiplication and print e
            double e = a * b; //32 bits

            //declare variable f and do division and print d 
            double f = a / b; //32 bits

            int value = 10; //32 bits

            double z = 10.2;
            double x = 2.2;
            double y = z + x;

          
            Console.WriteLine(c);
            Console.WriteLine("The result is " + d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            int radius = 10;
            //calculate area of cirlce and print it
            //3.14 or (22/7)
            double result=(double)22/7 * radius * radius;
            Console.WriteLine(result);

            //Console.WriteLine(22/ (double)7);
            bool check = true;
            char letter = 'B';

            Console.WriteLine(check);
            Console.WriteLine(letter);

            //Non-predefined datatype
            //string myName = "Balaji"; //6*2 bytes memory occupied
            //Console.WriteLine(myName);

            //10,20,30,40,50
            int[] numbers = new int[5]; //5*32 bits
            numbers[0] = 10;
            //numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            Console.WriteLine(numbers);

            Console.WriteLine(numbers[1]);

            //10.2, 45.3, 89.2
            double[] numbers2 = new double[3];  //3*64 bits
            numbers2[0] = 10.2;
            numbers2[1] = 45.3;

            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(numbers2[2]);

            //create an array to store red,green,yellow
            String[] colors=new string[3]; 
            colors[0] = "red";
            colors[1] = "green";
            colors[2] = "yellow";

            //3+5+6=14*16 bits of memory occupied

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            double rad = 10;

            int[] arr1 = { 90, 89, 66, 88 };
            string[] arr2 = { "red", "green", "blue", "yellow" };
            Console.WriteLine(arr1[3]);
            Console.WriteLine(arr2[1]);

            Console.WriteLine(arr2.Length);



            string myName = "Balaji"; //6*2 bytes memory occupied
            Console.WriteLine(myName);

            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.Length);
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName);
            //check for lowercase

            double radius1 = 10;

            double output=(4 * Math.PI * radius1 * radius1 * radius1) / 3;
            Console.WriteLine(output);

            //volume of cylinder
            double rad1 = 10;
            double height = 20;

            output=Math.PI * rad1 * rad1 * height;
            Console.WriteLine(output);

            Console.ReadLine();

        }
    }
}


