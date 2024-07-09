using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject3NUnit
{
    public class Demo4FrameTest
    {
        [Test]
        public void DemoFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //switch to frame
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //enter userid as john123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("jack123");

            //click on continue 
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();

            driver.Quit();
        }
    }
}
