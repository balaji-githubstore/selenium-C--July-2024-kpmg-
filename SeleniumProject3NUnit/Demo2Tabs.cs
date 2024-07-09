using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject3NUnit
{
    public class Demo2Tabs
    {
        [Test]
        public void Demo1MultipleTabs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            //b[contains(text(),'phpMyAdm')]
            driver.FindElement(By.PartialLinkText("phpMyAdmi")).Click();

            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            //enter password as admin123
            //click on go

            driver.Close(); //check what's happening on calling close();

            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            //print the title
            Console.WriteLine(driver.Title);

            driver.Quit();
        }

        [Test]
        public void CitibankTabs()
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //2.Close if any pop up comes
            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();

            //3.Click on Login
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //4.Click on Forgot User ID?
            driver.FindElement(By.XPath("//div[contains(text(),'Forgot User')]")).Click();

            //5.Choose Credit Card
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

            //6.Enter credit card number as 4545 5656 8887 9998
            driver.FindElement(By.CssSelector("#citiCard1")).SendKeys("3334");
            driver.FindElement(By.CssSelector("input[name='citiCard2']")).SendKeys("5555");
            //7.Enter cvv number

            //8.Enter date as “14 / 04 / 2022”
            //approach 1 - not works
            //driver.FindElement(By.Id("bill-date-long")).SendKeys("10/12/2022");

            //approach 2  //automate the calendar
            driver.FindElement(By.Id("bill-date-long")).Click();

            SelectElement selectYear = new SelectElement(driver.FindElement(By.XPath("//select[@data-handler='selectYear']")));
            selectYear.SelectByText("2022");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.XPath("//select[@data-handler='selectMonth']")));
            selectMonth.SelectByText("Dec");

            driver.FindElement(By.LinkText("14")).Click();

            //approach 3
            //javascript

            //9.Click on Proceed
            driver.FindElement(By.XPath("//input[@value='PROCEED']")).Click();
            //10.Get the text and print it “Please accept Terms and Conditions”

            string actualValue=driver.FindElement(By.XPath("//b[contains(text(),'One Time')]")).Text;
            Console.WriteLine(actualValue);

            
            string actualValue1 = driver.FindElement(By.XPath("//div[@role='dialog']")).Text;
            Console.WriteLine(actualValue1);

           
        }

    }
}
