using AventStack.ExtentReports;
using OpenCart.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpenCart
{
    public class CheckOutFlow
    {
       

        [Test]
        public void TestScenario1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/en-gb/catalog/tablet");
            Thread.Sleep(15000);
            AddtoCart cart = new AddtoCart(driver);
            cart.itemClick();
            checkoutPage checkoutpage = new checkoutPage(driver);
            checkoutpage.fillEstimationDetails();
            protected ExtentReports extent;

    }

    }
}
