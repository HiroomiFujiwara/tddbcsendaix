namespace StrawberryShipment
{
    public class Strawberry
    {
        public Strawberry(string cultivar, string size)
        {
            Cultivar = cultivar;
            Size = size;
        }

        public string Cultivar { get; }
        public string Size { get; }
    }
}
