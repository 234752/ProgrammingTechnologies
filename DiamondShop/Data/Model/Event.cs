using Data.API;

namespace Data.Model;

internal class Event : IEvent
{
    public int EventId { get; set; }
    public string Date { get; set; }
    public string IsDelivery { get; set; }  
    public int CatalogId { get; set; }
    public int CustomerId { get; set; }
    internal Event(int id,string date, string isDelivered, int catalogid, int customerid)
    {
        EventId = id;
        Date = date;
        IsDelivery = isDelivered;
        CatalogId = catalogid;
        CustomerId = customerid;
    }
}        
