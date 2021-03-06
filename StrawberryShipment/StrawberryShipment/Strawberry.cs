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
        private readonly string _size;

        /// <summary>
        /// �������𐶐�����B
        /// </summary>
        /// <param name="cultivar">�i��</param>
        /// <param name="size">�T�C�Y</param>
        public Strawberry(Cultivar cultivar, string size)
        {
            _cultivar = cultivar;
            _size = size;
        }

        public Strawberry(Cultivar cultivar, int weight)
        {
            _size = "LL";
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
