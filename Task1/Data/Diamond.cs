namespace Data
{
    internal enum QualityValue { Good = 1, VeryGood = 2, Excellent = 3 };

    internal enum ShapeValue { Round = 1, Oval = 2, Cushion = 3, Pear = 4 };

    internal class Diamond 
    {
        private float Carat { get; set; }
        private float Price { get; set; }
        private QualityValue Quality { get; set; }
		private ShapeValue Shape { get; set;}

        internal Diamond(float carat, float price, QualityValue quality, ShapeValue shape)
        {
            Carat = carat;
            Price = price;
            Quality = quality;
            Shape = shape;
        }
        public override string ToString()
        {
            return "Carat: " + Carat + ", Price: " + Price + ", Quality: " + Quality + ", Shape: " + Shape;
        }
        internal float GetPrice()
        {
            return Price;
        }
    }
}
