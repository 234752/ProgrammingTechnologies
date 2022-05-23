using Data.API;

namespace Data.Model
{
    public class Diamond : IDiamond
    {
        public int DiamondId { get;set; }
        public decimal Price { get; set; }
		public string Quality { get; set;}
        public string Name { get; set; }


        public Diamond(int id,decimal price, string quality, string name)
        {
            DiamondId = id;
            Price = price;
            Quality = quality;
            Name = name;
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
