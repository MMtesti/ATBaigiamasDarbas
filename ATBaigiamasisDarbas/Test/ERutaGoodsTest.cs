using NUnit.Framework;

namespace ATBaigiamasisDarbas.Test
{
    class ERutaGoodsTest : BaseTest
    {
        [Test]
        public static void TestGoodsList()
        {
            int index = 2;
            string expectedResult = "saldainiai";
            _eRutaGoodsPage.NavigateToDefaultPage();
            _eRutaGoodsPage.AcceptAlert();
            _eRutaGoodsPage.MoveToGoodsList();
            _eRutaGoodsPage.ChooseGoodsSubmeniu(index);
            _eRutaGoodsPage.VerifyMeniuResult(expectedResult);
        }
    }
}
