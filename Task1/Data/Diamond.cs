namespace Data
{
    enum QualityValue { Good, VeryGood, Excellent };

    internal class Diamond
    {
        private float Mass { get; set; }
        private float Price { get; set; }
        private QualityValue Quality { get; set; }

        internal Diamond(float mass, float price, QualityValue quality)
        {
            Mass = mass;
            Price = price;
            Quality = quality;
        }

    }
}
