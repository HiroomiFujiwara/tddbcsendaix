using System;
using System.Runtime.InteropServices.ComTypes;

namespace StrawberryShipment
{
    /// <summary>
    /// ������
    /// </summary>
    public class Strawberry
    {
        /// <summary>
        /// 品種
        /// </summary>
        private Cultivar _cultivar;

        /// <summary>
        /// �T�C�Y
        /// </summary>
        private readonly Size _size;

        /// <summary>
        /// �������𐶐�����B
        /// </summary>
        /// <param name="cultivar">�i��</param>
        /// <param name="size">�T�C�Y</param>
        public Strawberry(Cultivar cultivar, Size size)
        {
            _cultivar = cultivar;
            _size = size;
        }

        /// <summary>
        /// いちごを生成する。
        /// </summary>
        /// <param name="cultivar">品種/param>
        /// <param name="weight">重さ</param>
        public Strawberry(Cultivar cultivar, int weight)
        {
            _cultivar = cultivar;
            if (weight >= 25)
            {
                _size = Size.LL;
            }
            else if (weight >= 20)
            {
                _size = Size.L;
            }
            else if (weight >= 10)
            {
                _size = Size.M;
            }
            else if (weight >= 1)
            {
                _size = Size.S;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(weight), weight, "Zero or less than.");
            }
        }

        /// <summary>
        /// ������\�����擾����B
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{_cultivar}: {_size}";
        }
    }
}
