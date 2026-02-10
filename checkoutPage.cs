using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Internal;

namespace OpenCart.Pages
{
    public class checkoutPage
    {
        private readonly IWebDriver driver;
       

        public checkoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement checkoutButton => driver.FindElement(By.XPath("//a[text()='Checkout']"));
        IWebElement EstimateShippingPanel => driver.FindElement(By.XPath("//button[text()='Estimate Shipping & Taxes']"));

        IWebElement country => driver.FindElement(By.Id("input-country"));
        IWebElement Zone => driver.FindElement(By.Id("input-zone"));
        IWebElement postcode => driver.FindElement(By.Name("postcode"));

        public void fillEstimationDetails()
        {
            EstimateShippingPanel.Click();
            country.Click();
            selectZone();
            postcode.SendKeys("BHC34");
            checkoutButton.Click();
        }

        public void selectDropdown(IWebElement dropdown,string text)
        {
            SelectElement SE = new SelectElement(dropdown);
            SE.SelectByText(text);
        }

        public void selectZone()
        {
            selectDropdown(Zone, "cardiff");
        }
    }
}