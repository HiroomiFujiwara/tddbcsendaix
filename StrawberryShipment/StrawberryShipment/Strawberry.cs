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
        public Strawberry(string cultivar, string size)
        {
            _cultivar = new Cultivar(cultivar);
            Size = size;
        }

        /// <summary>
        /// �T�C�Y
        /// </summary>
        public string Size { get; }

        public Cultivar Cultivar1 => _cultivar;

        /// <summary>
        /// ������\�����擾����B
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Cultivar1.Value}: {Size}";
        }
    }
}
