using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBaigiamasisDarbas.Page;
using NUnit.Framework;

namespace ATBaigiamasisDarbas.Test
{
    class ERutaShoppingCartTest : BaseTest
    {
        [Test]
        
        public static void TestSearchAndShoppingCartFunction()
        {
            string searchText = "zele";
            _eRutaSearchPage.NavigateToDefaultPage();
            _eRutaSearchPage.AcceptAlert();
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            _eRutaSearchPage.ClickSearchSubmitButton();
            _eRutaSearchPage.AddFirstItemInToShoppingCart();

        }
    }
}
