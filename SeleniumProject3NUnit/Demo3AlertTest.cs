using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject3NUnit
{
    public class Demo3AlertTest
    {
        [Test]
        public void AlertDemoTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on Go
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            //wait for alert present
            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(30));
            wait.Until(x => x.SwitchTo().Alert());

            string actualAlertText=driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();
        }
       
    }
}



