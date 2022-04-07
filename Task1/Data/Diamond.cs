namespace Data
{
    public enum QualityValue { Good, VeryGood, Excellent };

    public enum ShapeValue { Round, Oval, Cushion, Pear };

   	  public class Diamond 
    {
        public Guid Id { get; set; }
        private float Carat { get; set; }
        private float Price { get; set; }
        private QualityValue Quality { get; set; }
		private ShapeValue Shape { get; set;}

        public Diamond(float carat, float price, QualityValue quality, ShapeValue shape)
        {
            Carat = carat;
            Price = price;
            Quality = quality;
            Shape = shape;
        }

    }
}
