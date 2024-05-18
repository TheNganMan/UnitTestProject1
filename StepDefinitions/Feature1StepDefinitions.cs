using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;
using UnitTestProject1.Setup;

namespace UnitTestProject1.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private LandingPage landingPage;
        private Context context;
        public Feature1StepDefinitions(LandingPage _landingPage, Context _context)
        {
            landingPage = _landingPage;
            context = _context; 
        }

        [Given(@"amazon webpage is loaded")]
        public void GivenAmazonWebpageIsLoaded()
        {
            context.LoadAmazonApplication();
        }

        [When(@"user click dismiss button")]
        public void WhenUserClickDismissButton()
        {
            landingPage.ClickOnDissmissBtn();
        }

        [When(@"a user clicks in search bar")]
        public void WhenAUserClicksInSearchBar()
        {
            landingPage.ClickOnsearchButton();
        }

        [When(@"a user fills in search box with (.*)")]
        public void WhenAUserFillsInSearchBoxWithIphone(string searchBoxdata)
        {
            landingPage.fillsInSearchBoxField(searchBoxdata);
        }

        [When(@"a user clicks on search button")]
        public void WhenAUserClicksOnSearchButton()
        {
            landingPage.ClickOnsearchButton();
        }

        [Then(@"all apple iphone products will be displayed")]
        public void ThenAllAppleIphoneProductsWillBeDisplayed()
        {
            //landingPage.VerifyAppleIphoneIsDisplayedAfterSearch();
            string actualResult = landingPage.VerifyAppleIphoneIsDisplayedAfterSearch();
            string expectedResult = "Apple iPhone 12 Mini, 128GB, Black - Unlocked (Renewed Premium)";
            Assert.AreEqual(expectedResult, actualResult);  
        }

        [AfterScenario]
        public void CloseAUT()
        {
            context.ShutDownAmazonApplication();
        }
    }
}
