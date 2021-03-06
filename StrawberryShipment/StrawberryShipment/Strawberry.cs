namespace StrawberryShipment
{
    /// <summary>
    /// いちご
    /// </summary>
    public class Strawberry
    {
        /// <summary>
        /// いちごを生成する。
        /// </summary>
        /// <param name="cultivar">品種</param>
        /// <param name="size">サイズ</param>
        public Strawberry(string cultivar, string size)
        {
            Cultivar = cultivar;
            Size = size;
        }

        /// <summary>
        /// 品種
        /// </summary>
        public string Cultivar { get; }

        /// <summary>
        /// サイズ
        /// </summary>
        public string Size { get; }

        /// <summary>
        /// 文字列表現を取得する。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Cultivar}: {Size}";
        }
    }
}
