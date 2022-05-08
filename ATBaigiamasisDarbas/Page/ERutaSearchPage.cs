using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaSearchPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/paieska";

        private IWebElement _searchInput => Driver.FindElement(By.Id("main-search-input"));
        private IWebElement _searchSubmitButton => Driver.FindElement(By.Id("main-search-submit"));
        private IWebElement _cartButton => Driver.FindElement(By.CssSelector("#middle_blocks > li > div.product-list.flex > div.grid_12.flex-item.product.product-simple.product-972.item_hover_wrap_972.alpha.item-line-first.hover-item.cp.mb10.item.zi1.product-item.item-list > div > div > div.item-price-cart-container > div.addToCart-container > form > a > strong"));
        private IReadOnlyCollection<IWebElement> _actualSearchResults => Driver.FindElements(By.ClassName("item-info-container"));
        private IWebElement _alertMessageDismissButton => Driver.FindElement(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a"));
        public ERutaSearchPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void AcceptAlert()
        {
            _alertMessageDismissButton.Click();
        }

        public void InsertTextToSerchField(string searchText)
        {
            _searchInput.SendKeys(searchText);
        }

        public void ClickSearchSubmitButton()
        {
            _searchSubmitButton.Click();
        }
         
         public void VerifySearchActualResults(string expectedResult)
        {
            foreach (IWebElement actualSearchResult in _actualSearchResults)
            {
                Assert.IsTrue(actualSearchResult.Text.ToLower().Contains(expectedResult), "The search found wrong goods");
            }    
        }
        
        public void AddFirstItemInToShoppingCart()
        {
          // foreach (IWebElement submitCartButton in _submitCartButtons)
            {
        //        _submitCartButtons.First().Click();
            }
        }
        public void AddToCart()
        {
            _cartButton.Click();
        }
    }
}
