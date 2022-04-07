namespace Data
{
    internal enum QualityValue { Good, VeryGood, Excellent };

    internal enum ShapeValue { Round, Oval, Cushion, Pear };

    internal class Diamond 
    {
        //public Guid Id { get; set; } //dictionary entry has a number which may be an id?
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

    }
}
