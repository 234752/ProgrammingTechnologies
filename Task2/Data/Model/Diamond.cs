using Data.API;

namespace Data.Model
{
    public class Diamond : IDiamond
    {
        public int DiamondId { get;set; }
        public decimal Price { get; set; }
		public string Quality { get; set;}
        

        public Diamond(int id,decimal price, string quality)
        {
            DiamondId = id;
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
