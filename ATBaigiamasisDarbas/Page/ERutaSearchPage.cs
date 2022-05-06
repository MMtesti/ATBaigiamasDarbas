using NUnit.Framework;
using OpenQA.Selenium;
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


        private IWebElement _searchInput => Driver.FindElement(By.CssSelector("#main-search-input")); // CssSelector "#main-search-input" ar Id("main-search-input")

        private IWebElement _searchSubmitButton => Driver.FindElement(By.Id("main-search-submit"));
        private IReadOnlyCollection<IWebElement> _submitCartButtons => Driver.FindElements(By.ClassName("addToCart-container"));

        private IReadOnlyCollection<IWebElement> _actualSearchResults => Driver.FindElements(By.ClassName("item-info-container"));

        public ERutaSearchPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
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
        public void AddGoodsInToShoppingCart()
        {
            _submitCartButtons.First().Click();
        }
        
    }
}
