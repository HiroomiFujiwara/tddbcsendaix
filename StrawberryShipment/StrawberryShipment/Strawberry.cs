using System.Collections.Generic;

namespace StrawberryShipment
{
    /// <summary>
    /// ������
    /// </summary>
    public class Strawberry
    {
        private readonly Cultivar _cultivar;

        /// <summary>
        /// �������𐶐�����B
        /// </summary>
        /// <param name="cultivar">�i��</param>
        /// <param name="size">�T�C�Y</param>
        public Strawberry(Cultivar cultivar, string size)
        {
            _cultivar = cultivar;
            Size = size;
        }

        /// <summary>
        /// �T�C�Y
        /// </summary>
        private readonly string Size;

        private Cultivar Cultivar => _cultivar;

        /// <summary>
        /// ������\�����擾����B
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Cultivar}: {Size}";
        }
    }
}
