using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/";

        private IWebElement _logInButton => Driver.FindElement(By.Id("login_fly_on"));
        private IWebElement _emailInput => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(1) > input"));
        private IWebElement _passwordInput => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(2) > input"));

        private IWebElement _submitButton => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > a.reg-btn.fl.btn1.submit-button.a0.mt15 > strong"));

        public ERutaPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void ClickLogInButton()
        {
            _logInButton.Click();
        }
        public void InsertTextToEmailField(string email)
        {
            _emailInput.SendKeys(email);
        }
        public void InsertTextToPasswordField(string password)
        {
            _passwordInput.SendKeys(password);
        }
        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }
    }
}
