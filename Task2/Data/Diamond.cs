namespace Data
{
    internal class Diamond 
    {
        private decimal Price { get; set; }
		private string Quality { get; set;}

        internal Diamond(decimal price, string quality)
        {
            Price = price;
            Quality = quality;
        }
        public override string ToString()
        {
            return ", Price: " + Price + ", Quality: " + Quality;
        }
        internal decimal GetPrice()
        {
            return Price;
        }
    }
}
