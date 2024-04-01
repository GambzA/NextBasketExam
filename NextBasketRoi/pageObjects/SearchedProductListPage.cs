using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketRoi.pageObjects
{
    public class SearchedProductListPage
    {
        private IWebDriver driver;
    
        By targetProduct = By.CssSelector("[data-atcb-uid='atcb-B08C3YBBHM-1'] [type]");
        By targetProductLink = By.LinkText("TP-Link AX5400 WiFi 6 Router (Archer AX73)- Dual Band Gigabit Wireless Internet Router, High-Speed ax Router for Streaming, Long Range Coverage, 5 GHz");

        public SearchedProductListPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement getTargetProduct()
        {
            return driver.FindElement(targetProduct);
        }

        public IWebElement getTargetProductLink()
        {
            return driver.FindElement(targetProductLink);
        }

    }
}
