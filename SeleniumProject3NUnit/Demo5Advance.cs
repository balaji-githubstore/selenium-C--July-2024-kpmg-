using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumProject3NUnit
{
    public class Demo5Advance
    {
        [Test]
        public void UploadTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://smallpdf.com/pdf-to-word";

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys("C:\\demo.pdf");
        }

        [Test]
        public void MouseTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.myntra.com/shop/men";

            Actions actions=new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Profile']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='login / Signup']")).Click();
        }

        [Test]
        public void KeyboardTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.google.com";

            Actions actions = new Actions(driver);
           
            actions.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift)
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).SendKeys(Keys.Enter)
                .SendKeys(Keys.Enter).SendKeys(Keys.Enter).Perform();
        }


        [Test]
        public void FindELementsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.google.com";

            var elements= driver.FindElements(By.TagName("a"));
            Console.WriteLine(elements.Count);

            elements[1].Click();
        }
    }
}
