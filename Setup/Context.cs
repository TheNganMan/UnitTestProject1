using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;



namespace UnitTestProject1.Setup
{
    public class Context
    {
        public IWebDriver driver;
        public string baseUrl = "https://www.amazon.com/";

        public void LoadAmazonApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            Thread.Sleep(4000);
        }

        public void ShutDownAmazonApplication()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
