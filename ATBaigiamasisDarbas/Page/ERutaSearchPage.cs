using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaSearchPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/paieska";

        private IWebElement _searchInput => Driver.FindElement(By.Id("main-search-input"));
        private IWebElement _searchSubmitButton => Driver.FindElement(By.Id("main-search-submit"));
        private IReadOnlyCollection<IWebElement> _cartButtons => Driver.FindElements(By.CssSelector("a.pr.zitt.vv.addCart.btn1.a0.fl.mr5"));
        private IReadOnlyCollection<IWebElement> _actualSearchResults => Driver.FindElements(By.ClassName("item-info-container"));
        private IWebElement _alertMessageDismissButton => Driver.FindElement(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a"));
        public ERutaSearchPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void AcceptAlert()
        {
            //if (IsElementPresent(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a")))
            //{
                _alertMessageDismissButton.Click();
            //}
            //else
           // {
            //    _searchInput.Clear();
            //}
        }

        public void InsertTextToSerchField(string searchText)
        {
            _searchInput.Clear();
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
                Assert.IsTrue(actualSearchResult.Text.ToLower().Contains(expectedResult.ToLower()), "Goods dont exist");
            }    
        }
        
        public void AddItemInToShoppingCart(int index)
        {
                _cartButtons.ElementAt(index).Click();
        }
       
    }
}
