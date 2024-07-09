using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.SeleniumProject3NUnit
{
    public class Demo1BasicTest
    {

        [Test]
        public void FBRegisterTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.Facebook.com/"; //wait for page load to complete
          
            //FindElement - takes only 0.5s to check the presence
            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();
            //enter firstname as john
            driver.FindElement(By.Name("firstname")).SendKeys("john");
            //enter lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            //enter password as welcome123
            driver.FindElement(By.Id("password_step_input")).SendKeys("hello123");

            //click on custom radio button
            //label[text()='Custom']
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //20 Dec 2000

            //select day
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");

            //select month
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.XPath("//select[@id='month']")));
            selectMonth.SelectByText("Dec");
            //selectMonth.SelectByValue("12");
            //selectMonth.SelectByIndex(11);

            //select year as 2000
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2000");

            //click on signup
            driver.FindElement(By.Name("websubmit")).Click();

        }

        [Test]
        public void SalesForceSignUpTest()
        {
            IWebDriver obj = new ChromeDriver();
            obj.Manage().Window.Maximize();
            obj.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            obj.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/?d=70130000000Enyk";

            //enter firstname as John
            //input[contains(@id,'UserFirst')]
            obj.FindElement(By.Name("UserFirstName")).SendKeys("jack");
            //enter lastname as wick
            obj.FindElement(By.Name("UserLastName")).SendKeys("wick");

            SelectElement selectCountry = new SelectElement(obj.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");

            //select Job title as IT Manager
            SelectElement selectTitle = new SelectElement(obj.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");

            //click on checkbox
            obj.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();

        }


    }
}
