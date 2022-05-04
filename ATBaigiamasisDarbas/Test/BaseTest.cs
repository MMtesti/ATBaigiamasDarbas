using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBaigiamasisDarbas.Drivers;
using ATBaigiamasisDarbas.Page;
using ATBaigiamasisDarbas.Tools;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Interfaces;

namespace ATBaigiamasisDarbas.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static ERutaPage _eRutaPage;
        public static ERutaSearchPage _eRutaSearchPage;
        public static ERutaShoppingCartPage _eRutaShoppingCartPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            _eRutaPage = new ERutaPage(Driver);
            _eRutaSearchPage = new ERutaSearchPage(Driver);
            _eRutaShoppingCartPage = new ERutaShoppingCartPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }
    }
}
