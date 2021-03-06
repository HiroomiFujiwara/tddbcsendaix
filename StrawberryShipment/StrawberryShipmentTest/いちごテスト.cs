using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StrawberryShipment;
using Xunit;

namespace StrawberryShipmentTest
{
    public class いちごテスト
    {
        [Fact(DisplayName = "品種とサイズを与えて、いちごを作成できる")]
        public void StrawberryCreateTest()
        {
            // 準備実行
            var strawberry = new Strawberry("あまおう", "S");

            // 結果
            Assert.Equal("あまおう", strawberry.Cultivar);
            Assert.Equal("S", strawberry.Size);
        }
    }

}
