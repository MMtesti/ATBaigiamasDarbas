﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBaigiamasisDarbas.Page;

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
