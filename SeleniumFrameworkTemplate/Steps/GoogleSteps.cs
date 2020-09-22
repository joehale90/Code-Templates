using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumFrameworkTemplate
{
    [Binding, Scope(Feature = "Google Testing")]
    public class GoogleSteps
    {
        [BeforeScenario]
        public void PreTests()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
        }

        [When(@"I browse to Google")]
        public void WhenIBrowseToGoogle()
        {
            Driver.driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Then(@"the google home page should be displayed")]
        public void ThenTheGoogleHomePageShouldBeDisplayed()
        {
            HomePage homePage = new HomePage();
            Assert.IsTrue(homePage.IsVisible());
        }

        [AfterScenario]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
