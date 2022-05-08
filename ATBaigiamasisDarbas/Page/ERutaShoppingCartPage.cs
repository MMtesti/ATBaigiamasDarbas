using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaShoppingCartPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/prekiu-krepselis";

        private IWebElement _shoppingCart => Driver.FindElement(By.Id("cart-inner"));// prekiu krepselis
        private IWebElement _cartValue => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/div/div[5]/div/div[1]/text()"));// krepselis tuscias
        private IWebElement _alertMessageDismissButton => Driver.FindElement(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a"));
        private IWebElement _ShoppingCartActualResult => Driver.FindElement(By.CssSelector("#cart_form > div > table > tbody > tr:nth-child(4) > td.grid-29.prefix_1.pt5.pb5.hidden-xs > a"));
        public ERutaShoppingCartPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void AcceptAlert()
        {
            _alertMessageDismissButton.Click();
        }
       // public void WaitUntilShoppingCartDisplayed()

        //{
       //     WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
       //     wait.Until(e => e.FindElement(By.Id("cart-inner")));
        //}

        public void ClickOnViewShoppingButton()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(_shoppingCart).Build().Perform();
            _shoppingCart.Click();
        }
        public void VerifyShoppingCartInfo(string expectedResult)
        {
            Assert.IsTrue(_ShoppingCartActualResult.Text.ToLower().Contains(expectedResult), "Wrong");
        }
    }
}
