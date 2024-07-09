using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject2
{
    public class Demo1Basics
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            Console.WriteLine(driver.Title);

            //get the url and print it 
            Console.WriteLine(driver.Url);

            //get the PageSource and print it
            //Console.WriteLine(driver.PageSource);

            // driver.FindElement(By.Id("email")).SendKeys("bala123334545@gmail.com");

            //By loc= By.Id("email");
            //IWebElement element= driver.FindElement(loc);
            //element.SendKeys("hello123444@gmail.com");


            IWebElement element = driver.FindElement(By.Id("email"));
            element.SendKeys("hello123444@gmail.com");

            driver.FindElement(By.Id("email")).SendKeys("hello123444@gmail.com");

            driver.FindElement(By.Id("pass")).SendKeys("welcome123");

            //click on login
            driver.FindElement(By.Name("login")).Click();
            
           // driver.Fi


        }
    }
}
