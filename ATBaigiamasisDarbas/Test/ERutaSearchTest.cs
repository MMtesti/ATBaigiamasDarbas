using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBaigiamasisDarbas.Page;

namespace ATBaigiamasisDarbas.Test
{
    class ERutaSearchTest : BaseTest
    {
        [TestCase("zele", "želė", TestName = "Find 'zele'")]
        [TestCase("marmurine", "marmurinė", TestName = "Find 'marmurine'")]
        [TestCase("agrastai", "agrastai", TestName = "Find 'agrastai'")]


        public static void TestSearchField(string searchText, string expectedResult)

        {
            _eRutaSearchPage.NavigateToDefaultPage();
            //_eRutaSearchPage.AcceptAlert();
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            _eRutaSearchPage.ClickSearchSubmitButton();
            _eRutaSearchPage.VerifySearchActualResults(expectedResult);
        }

    }
}
