using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaGoodsPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/produktai";

        private IWebElement _goodsList => Driver.FindElement(By.Id("top_menu_link_1735"));
        private IWebElement _alertMessageDismissButton => Driver.FindElement(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a"));
        private IReadOnlyCollection<IWebElement> _SubMeniu => Driver.FindElements(By.ClassName("link-level3"));
        private IWebElement _actualResult => Driver.FindElement(By.Id("heading1"));
        public ERutaGoodsPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void AcceptAlert()
        {
            _alertMessageDismissButton.Click();
        }

        public void MoveToGoodsList()
            {
            Actions action = new Actions(Driver);
            action.MoveToElement(_goodsList);
            action.Build().Perform();
        }
        public void ChooseGoodsSubmeniu(int index)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(_SubMeniu.ElementAt(index));
            action.Build().Perform();
            _SubMeniu.ElementAt(index).Click();
        }
        public void VerifyMeniuResult(string expectedResult)
        {
            Assert.AreEqual($"{expectedResult}", _actualResult.Text.ToLower(), "Wrong selection");
        }
    }
}
