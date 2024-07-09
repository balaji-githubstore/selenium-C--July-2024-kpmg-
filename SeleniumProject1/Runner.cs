using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            IWebDriver obj=new EdgeDriver();

            obj.Url = "http://facebook.com";

            Console.WriteLine(obj.Url);

            Console.WriteLine(obj.Title);

            obj.Quit();
        }
    }
}
