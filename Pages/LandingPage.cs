using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Setup;
using OpenQA.Selenium;
using System.Threading;
using System.Security.Policy;

namespace UnitTestProject1.Pages
{

    public class LandingPage
    {
        private Context context;

        public LandingPage(Context _context)
        {
            context = _context;
        }

        By searchBox = By.Id("twotabsearchtextbox");
        By searchButton = By.Id("nav-search-submit-button");
        By dissmiss = By.XPath("//*[@id=\"nav-main\"]/div[1]/div/div/div[3]/span[1]/span/input");
        By iPhone = By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[3]/div/div/span/div/div/div/div[2]/div/div/div[1]/h2/a/span");

      public void ClickOnDissmissBtn()
        {
            System.Threading.Thread.Sleep(4000);
            context.driver.FindElement(dissmiss).Click();
        }
        public void ClickOnsearchBox()
        {
            System.Threading.Thread.Sleep(4000);
            context.driver.FindElement(searchBox).Click();
        }

        public void fillsInSearchBoxField(string searchBoxdata)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement searchBoxTxtlink = context.driver.FindElement(searchBox);
            searchBoxTxtlink.Clear();
            searchBoxTxtlink.SendKeys(searchBoxdata);   
        }

        public void ClickOnsearchButton() 
        {
            context.driver.FindElement(searchButton).Click();
        }

        public string VerifyAppleIphoneIsDisplayedAfterSearch()
        {
            return context.driver.FindElement(iPhone).Text.Trim();
        }
    }
}
