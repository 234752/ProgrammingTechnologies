using Data.API;

namespace Data.Model
{
    public class Diamond //: IDiamond
    {
        private int Id;
        private decimal Price { get; set; }
		private string Quality { get; set;}

        internal Diamond(int id,decimal price, string quality)
        {
            Id = id;
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
