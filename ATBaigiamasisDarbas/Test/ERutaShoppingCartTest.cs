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
        
        public static void TestSearchAndShoppingCartFunction(string searchText)
        {
            _eRutaShoppingCartPage.NavigateToDefaultPage();
            _eRutaSearchPage.InsertTextToSerchField(searchText);


        }
    }
}
