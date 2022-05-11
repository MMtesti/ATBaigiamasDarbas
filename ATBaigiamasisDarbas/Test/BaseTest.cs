using ATBaigiamasisDarbas.Drivers;
using ATBaigiamasisDarbas.Page;
using ATBaigiamasisDarbas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;

namespace ATBaigiamasisDarbas.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static ERutaPage _eRutaPage;
        public static ERutaSearchPage _eRutaSearchPage;
        public static ERutaShoppingCartPage _eRutaShoppingCartPage;
        public static ERutaGoodsPage _eRutaGoodsPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            _eRutaPage = new ERutaPage(Driver);
            _eRutaSearchPage = new ERutaSearchPage(Driver);
            _eRutaShoppingCartPage = new ERutaShoppingCartPage(Driver);
            _eRutaGoodsPage = new ERutaGoodsPage(Driver);
        }
        
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
           Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }
    }
}
