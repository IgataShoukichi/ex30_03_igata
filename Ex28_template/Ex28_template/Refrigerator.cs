namespace Inheritance
{
    class Refrigerator : Thing
    {
        public float _price;

        public float Price
        {
            get { return _price; }
        }
        public Refrigerator(float price, string n, float w, float h, float d, float we) : base(n, w, h, d, we)
        {
            _price = price;
        }
    }
}
