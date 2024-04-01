using NextBasketRoi.pageObjects;
using NextBasketRoi.utilities;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NextBasketRoi.tests
{
    [Parallelizable(ParallelScope.Self)]
    public class AmazonShop : Base
    {
        [Test, Category("Smoke")]
        public void TestPurchase()
        {
            Homepage home = new Homepage(getDriver());
            home.getSearchBar().SendKeys("AX5400 WiFi 6 Router (Archer AX73)- ");
            home.getSearchBtn().Click();

            SearchedProductListPage searchResult = new SearchedProductListPage(getDriver());
            searchResult.getTargetProductLink().Click();

            ProductPage product = new ProductPage(getDriver());
            product.getAddToCartBtn().Click();

            Header header = new Header(getDriver());

            WebDriverWait wait = new WebDriverWait(getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(header.getSideBarCartElement()));

            header.getGotoCardBtn().Click();

            CartPage cart = new CartPage(getDriver());
            String item = cart.getCartProductTitle().Text;
            String total = cart.getCartTotalPrice().Text;
            try
            {
                Assert.That(item, Is.EqualTo("TP-Link AX5400 WiFi 6 Router (Archer AX73)- Dual Band Gigabit Wireless Internet Router, High-Speed ax Router for Streaming, Long Range Coverage, 5 GHz"));
                Assert.That(total, Is.EqualTo("$149.99"));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }

}
