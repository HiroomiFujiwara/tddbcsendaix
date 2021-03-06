using System.Runtime.InteropServices.ComTypes;
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
            var strawberry = new Strawberry(cultivar, Size.S);
            Assert.Equal(expected, strawberry.ToString());
        }

        [Theory(DisplayName = "サイズの種類は「S」「M」「L」「LL」が指定できる")]
        [InlineData(Size.S)]
        [InlineData(Size.M)]
        [InlineData(Size.L)]
        [InlineData(Size.LL)]
        public void StringSize(Size expected)
        {
            var strawberry = new Strawberry(Cultivar.あまおう, expected);
            Assert.Equal($"あまおう: {expected}",strawberry.ToString());
        }

        [Theory(DisplayName = "いちごに重さを直接与えてサイズの文字列表現が決まる")]
        [InlineData(25,"あまおう: LL")]
        [InlineData(20,"あまおう: L")]
        public void StringWeightSize(int weight, string expected)
        {
            var strawberry = new Strawberry(Cultivar.あまおう, weight);
            Assert.Equal(expected, strawberry.ToString());
        }
    }
}
