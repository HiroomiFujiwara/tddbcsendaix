using StrawberryShipment;
using Xunit;

namespace StrawberryShipmentTest
{
    public class いちごテスト
    {
        [Theory(DisplayName = "いちごの文字列表現が「品種: サイズ」である")]
        [InlineData(Cultivar.あまおう, "あまおう: S")]
        [InlineData(Cultivar.とちおとめ, "とちおとめ: S")]
        [InlineData(Cultivar.もういっこ, "もういっこ: S")]
        public void StringIsCultivarSize(Cultivar cultivar, string expected)
        {
            var strawberry = new Strawberry(cultivar, "S");
            Assert.Equal(expected, strawberry.ToString());
        }

        [Theory(DisplayName = "サイズの種類は「S」「M」「L」「LL」が指定できる")]
        [InlineData("S")]
        [InlineData("M")]
        [InlineData("L")]
        [InlineData("LL")]
        public void StringSize(string expected)
        {
            var strawberry = new Strawberry(Cultivar.あまおう, expected);
            Assert.Equal($"あまおう: {expected}",strawberry.ToString());
        }
    }
}
