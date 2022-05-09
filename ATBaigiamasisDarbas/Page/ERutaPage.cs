using NUnit.Framework;
using OpenQA.Selenium;

namespace ATBaigiamasisDarbas.Page
{
    class ERutaPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/";

        private IWebElement _logInButton => Driver.FindElement(By.Id("login_fly_on"));
        private IWebElement _emailInput => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(1) > input"));
        private IWebElement _passwordInput => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > div:nth-child(2) > input"));
        private IWebElement _submitButton => Driver.FindElement(By.CssSelector("#login_form_modal > div > div > a.reg-btn.fl.btn1.submit-button.a0.mt15 > strong"));
        private IWebElement _actualSuccessLogIn => Driver.FindElement(By.Id("account_on"));
        private IWebElement _alertMessageDismissButton => Driver.FindElement(By.CssSelector("#template_body_col_2_left > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override--575221361 > div > a"));
        public ERutaPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void AcceptAlert()
        {
            _alertMessageDismissButton.Click();
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
        
        public void VerifySuccessLogIn(string expectedResult)
        {
            Assert.IsTrue(_actualSuccessLogIn.Text.ToLower().Contains(expectedResult.ToLower()), "Wrong username or password");
        }
    }
}
