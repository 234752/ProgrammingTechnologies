namespace Data
{
    enum QualityValue { Good, VeryGood, Excellent };
    enum ShapeValue { Round, Oval, Cushion, Pear };

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

    }
}
