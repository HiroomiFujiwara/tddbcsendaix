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
            var strawberry = new Strawberry(Cultivar.あまおう, "S");

            // 結果
            Assert.Equal(Cultivar.あまおう, strawberry.Cultivar1);
            Assert.Equal("S", strawberry.Size);
        }

        [Fact(DisplayName = "いちごの文字列表現が「品種: サイズ」である")]
        public void StringIsCultivarSize()
        {
            var strawberry = new Strawberry(Cultivar.あまおう, "S");
            Assert.Equal("あまおう: S", strawberry.ToString());
        }

        [Fact(DisplayName = "品種の種類は「あまおう」が指定できる")]
        public void DisplayAmaou()
        {
            var strawberry = new Strawberry(Cultivar.あまおう, "S");
            Assert.Equal(Cultivar.あまおう, strawberry.Cultivar1);
        }

        [Fact(DisplayName = "品種の種類は「とちおとめ」が指定できる")]
        public void DisplayTotciotome()
        {
            var strawberry = new Strawberry(Cultivar.とちおとめ, "S");
            Assert.Equal(Cultivar.とちおとめ, strawberry.Cultivar1);
        }

        [Fact(DisplayName = "品種の種類は「もういっこ」が指定できる")]
        public void DisplayMouikko()
        {
            var strawberry = new Strawberry(Cultivar.もういっこ, "S");
            Assert.Equal(Cultivar.もういっこ, strawberry.Cultivar1);
        }
    }

}
