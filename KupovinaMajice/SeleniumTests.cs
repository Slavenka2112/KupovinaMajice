using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace KupovinaMajice
{
    class SeleniumTests
    {
        IWebDriver driver;

        [Test]
        public void Search()
        {
            IWebElement form_search = driver.FindElement(By.Name("search_query"));
            if (form_search.Enabled) form_search.SendKeys("faded");

            IWebElement button_search = driver.FindElement(By.Name("submit_search"));
            if (button_search.Enabled) button_search.Click();

           

            Wait(4000);
        }
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        static private void Wait(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }
    }
}