using System;

namespace StrawberryShipment
{
    /// <summary>
    /// 品種
    /// </summary>
    public class Cultivar
    {
        /// <summary>
        /// 品種を生成する。
        /// </summary>
        /// <param name="value">品種</param>
        public Cultivar(string value)
        {
            switch (value)
            {
                case "あまおう":
                    break;

                default:
                    throw new ArgumentException();
            }
            Value = value;
        }

        /// <summary>
        /// �i��
        /// </summary>
        public string Value { get; }
    }
}