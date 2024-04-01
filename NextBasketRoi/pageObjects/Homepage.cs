using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketRoi.pageObjects
{
    public class Homepage
    {
        private IWebDriver driver;
    
        By searchBar = By.CssSelector("input#twotabsearchtextbox");
        By searchBtn = By.CssSelector("input#nav-search-submit-button");

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public IWebElement getSearchBar()
        {
            return driver.FindElement(searchBar);
        }

        public IWebElement getSearchBtn()
        {
            return driver.FindElement(searchBtn);
        }
    }
}
