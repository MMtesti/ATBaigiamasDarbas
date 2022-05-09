using OpenQA.Selenium;

namespace ATBaigiamasisDarbas.Page
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
    }
}
