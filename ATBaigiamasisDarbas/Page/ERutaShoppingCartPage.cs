using OpenQA.Selenium;
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
        public ERutaShoppingCartPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

    }
}
