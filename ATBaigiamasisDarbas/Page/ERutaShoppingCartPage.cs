using NUnit.Framework;
using OpenQA.Selenium;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaShoppingCartPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/prekiu-krepselis";

        private IWebElement _shoppingCart => Driver.FindElement(By.Id("cart-link"));
        private IWebElement _alertMessageDismissButton => Driver.FindElement(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a"));
        private IWebElement _ShoppingCartActualResult => Driver.FindElement(By.CssSelector("td.grid-29.prefix_1.pt5.pb5.hidden-xs"));
        public ERutaShoppingCartPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void AcceptAlert()
        {
            _alertMessageDismissButton.Click();
        }

        public void ClickOnViewShoppingButton()
        {
            _shoppingCart.Click();
        }
        public void VerifyShoppingCartInfo(string expectedResult)
        {
            Assert.IsTrue(_ShoppingCartActualResult.Text.Contains(expectedResult), "Wrong");
        }
    }
}
