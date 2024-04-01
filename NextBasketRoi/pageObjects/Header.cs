using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketRoi.pageObjects
{
    public class Header
    {
        private IWebDriver driver;
    
        By cartBtn = By.CssSelector("a#nav-cart");
        By goToCardBtn = By.LinkText("Go to Cart");
        By sideBarCart = By.CssSelector("div#ewc-content");

        public Header(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getCartBtn()
        {
            return driver.FindElement(cartBtn);
        }

        public IWebElement getGotoCardBtn()
        {
            return driver.FindElement(goToCardBtn);
        }

        public IWebElement getSideBarCart()
        {
            return driver.FindElement(sideBarCart);
        }

        public By getSideBarCartElement()
        {
            return sideBarCart;
        }
    }
}
