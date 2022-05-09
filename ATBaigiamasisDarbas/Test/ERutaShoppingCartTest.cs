﻿using System;
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
            string expectedResult = "1953ZELE2";
            int index = 1;
            _eRutaSearchPage.NavigateToDefaultPage();
            _eRutaSearchPage.AcceptAlert();
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            _eRutaSearchPage.ClickSearchSubmitButton();
            _eRutaSearchPage.AddFirstItemInToShoppingCart(index);
            _eRutaShoppingCartPage.ClickOnViewShoppingButton();
            _eRutaShoppingCartPage.VerifyShoppingCartInfo(expectedResult);

        }

        /*
        [TestCase("zele", "1", "1953ZELE2", TestName = "ShoppingCart 'zele'")]
        [TestCase("zara", "7", "9387RINK", TestName = "ShoppingCart 'zara'")]
        [TestCase("agrastai", "0", "9294DRAZ", TestName = "ShoppingCart 'agrastai'")]


        public static void TestSearchAndShoppingCartFunction(string searchText, int index, string expectedResult)
        {
            _eRutaSearchPage.NavigateToDefaultPage();
            _eRutaSearchPage.AcceptAlert();
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            _eRutaSearchPage.ClickSearchSubmitButton();
            _eRutaSearchPage.AddFirstItemInToShoppingCart(index);
            _eRutaShoppingCartPage.ClickOnViewShoppingButton();
            _eRutaShoppingCartPage.VerifyShoppingCartInfo(expectedResult);
        }
        */
    }

}
