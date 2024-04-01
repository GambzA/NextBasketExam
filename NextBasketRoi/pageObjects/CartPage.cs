using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketRoi.pageObjects
{
    public class CartPage
    {
        private IWebDriver driver;
    
        By cartProductTitle = By.CssSelector("[data-a-word-break] [aria-hidden]");
        By cartTotalPrice = By.CssSelector("#sc-subtotal-amount-activecart .sc-white-space-nowrap");

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getCartProductTitle()
        {
            return driver.FindElement(cartProductTitle);
        }

        public IWebElement getCartTotalPrice()
        {
            return driver.FindElement(cartTotalPrice);
        }

    }
}
