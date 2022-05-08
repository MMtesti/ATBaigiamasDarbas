using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBaigiamasisDarbas.Page;

namespace ATBaigiamasisDarbas.Test
{
    class ERutaTest : BaseTest
    {
        [Test]
        public static void TestLogin()
        {
            string email = "kumiTestai@gmail.com";
            string password = "smaliziai123";
            string expectedResult = "kumi";
            _eRutaPage.NavigateToDefaultPage();
            _eRutaPage.AcceptAlert();
            _eRutaPage.ClickLogInButton();
            _eRutaPage.InsertTextToEmailField(email);
            _eRutaPage.InsertTextToPasswordField(password);
            _eRutaPage.ClickSubmitButton();
            _eRutaPage.VerifySuccessLogIn(expectedResult);

        }
    }
}
