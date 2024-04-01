using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketRoi.pageObjects
{
    public class ProductPage
    {
        private IWebDriver driver;
    
        By addToCartBtn = By.CssSelector("input#add-to-cart-button");

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getAddToCartBtn()
        {
            return driver.FindElement(addToCartBtn);
        }

    }
}
