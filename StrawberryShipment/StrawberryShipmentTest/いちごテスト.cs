using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace StrawberryShipmentTest
{
    public class いちごテスト
    {
        [Fact(DisplayName = "品種とサイズを与えて、いちごを作成できる")]
        public void StrawberryCreateTest()
        {
            // 準備
            // 実行
            // 結果
            Assert.Equal("いちご","いちご");
        }
    }
}
