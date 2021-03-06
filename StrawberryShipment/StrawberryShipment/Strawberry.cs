using System.Collections.Generic;

namespace StrawberryShipment
{
    /// <summary>
    /// ������
    /// </summary>
    public class Strawberry
    {
        /// <summary>
        /// �������𐶐�����B
        /// </summary>
        /// <param name="cultivar">�i��</param>
        /// <param name="size">�T�C�Y</param>
        public Strawberry(string cultivar, string size)
        {
            Cultivar = cultivar;
            Size = size;
        }

        /// <summary>
        /// �i��
        /// </summary>
        public string Cultivar { get; }

        /// <summary>
        /// �T�C�Y
        /// </summary>
        public string Size { get; }

        /// <summary>
        /// ������\�����擾����B
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Cultivar}: {Size}";
        }

        public IEnumerable<char> Display()
        {
            throw new System.NotImplementedException();
        }
    }
}
