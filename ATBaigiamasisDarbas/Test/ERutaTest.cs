using NUnit.Framework;

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
            _eRutaPage.ClickLogOutButton();

        }
    }
}
