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
        //public bool IsElementPresent(By by)
        //{
        //    try
        //    {
        //        Driver.FindElement(by);
        //        return true;
         //   }
         //   catch (NoSuchElementException)
          //  {
           //     return false;
           // }
           //}
     
    }
}
