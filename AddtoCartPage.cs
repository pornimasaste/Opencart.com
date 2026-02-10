using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCart.Pages
{
    public class AddtoCart
    {
        private readonly IWebDriver driver;

        public AddtoCart(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement cameraName => driver.FindElement(By.XPath("(//a[text()='Samsung Galaxy Tab 10.1'])[1]"));
        IWebElement quanityValue => driver.FindElement(By.XPath("//input[@name='quantity']"));
        IWebElement addToCartButton => driver.FindElement(By.XPath("(//a[text()='Samsung Galaxy Tab 10.1'])[1]"));

        IWebElement shoppingCart => driver.FindElement(By.XPath("(//i[contains(@class,'fa-cart-shopping')])[1]"));

        
        public void itemClick()
        {
            cameraName.Click();
            quanityValue.SendKeys("2");
            addToCartButton.Click();
            shoppingCart.Click();
            
        }
    }
}
