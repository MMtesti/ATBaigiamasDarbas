using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;

namespace ATBaigiamasisDarbas.Test
{
    class ERutaShoppingCartTest : BaseTest
    {

        [Test]
        
        public static void TestSearchAndShoppingCartFunction()
        {
            string searchText = "zele";
            string expectedResult = "1953ZELE2";
            int index = 1;
            _eRutaSearchPage.NavigateToDefaultPage();
            _eRutaSearchPage.AcceptAlert();
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            _eRutaSearchPage.ClickSearchSubmitButton();
            _eRutaSearchPage.AddItemInToShoppingCart(index);
            _eRutaShoppingCartPage.ClickOnViewShoppingButton();
            _eRutaShoppingCartPage.VerifyShoppingCartInfo(expectedResult);

        }

        [Test]
        public static void TestLoginAndOrderFunction()
        {
            string email = "kumiTestai@gmail.com";
            string password = "smaliziai123";
            int index = 3;
            string searchText = "Zara";
            _eRutaPage.NavigateToDefaultPage();
            _eRutaPage.AcceptAlert();
            _eRutaPage.ClickLogInButton();
            _eRutaPage.InsertTextToEmailField(email);
            _eRutaPage.InsertTextToPasswordField(password);
            _eRutaPage.ClickSubmitButton();
            Thread.Sleep(3000);
            _eRutaGoodsPage.MoveToGoodsList();
            Thread.Sleep(3000);
            _eRutaGoodsPage.ChooseGoodsSubmeniu(index);
            Thread.Sleep(3000);
            _eRutaSearchPage.AddItemInToShoppingCart(index);
            Thread.Sleep(3000);
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            Thread.Sleep(3000);
            _eRutaSearchPage.ClickSearchSubmitButton();
            Thread.Sleep(3000);
            _eRutaSearchPage.AddItemInToShoppingCart(index);
            _eRutaShoppingCartPage.ClickOnViewShoppingButton();
        }
        
    }

}
