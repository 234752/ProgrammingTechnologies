using Data.API;

namespace Data.Model;

internal class Event : IEvent
{
    public int EventId { get; set; }
    public string Date { get; set; }
    public string IsDelivery { get; set; }  
    public int DiamondId { get; set; }
    public int CustomerId { get; set; }
    internal Event(int id,string date, string isDelivered, int diamondId, int customerid)
    {
        EventId = id;
        Date = date;
        IsDelivery = isDelivered;
        DiamondId = diamondId;
        CustomerId = customerid;
    }
    internal Event() { }
}        
