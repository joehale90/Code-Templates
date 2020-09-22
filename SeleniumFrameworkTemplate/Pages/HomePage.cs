using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SeleniumFrameworkTemplate

{
    public class HomePage
    {

        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "hplogo")]
        public IWebElement GoogleHomePageLogo { get; set; }


        public bool IsVisible()
        {
            var waitForPageToLoad = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
            waitForPageToLoad.Until(driver => GoogleHomePageLogo.Displayed);
            return true;
        }

    }

}
