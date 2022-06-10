using Data.API;

namespace Data.Model;

internal class Diamond : IDiamond
{
    public int DiamondId { get;set; }
    public decimal Price { get; set; }
    public string Quality { get; set;}
    public string Name { get; set; }

    internal Diamond(int id,decimal price, string quality, string name)
    {
        DiamondId = id;
        Price = price;
        Quality = quality;
        Name = name;
    }
    internal Diamond() { }
}

