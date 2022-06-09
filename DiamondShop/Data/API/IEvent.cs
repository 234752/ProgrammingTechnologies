
namespace Data.API;

public interface IEvent
{
    string Date { get; set; }
    int EventId { get; set; }
    string IsDelivery { get; set; }
    int DiamondId { get; set; }
    int CustomerId { get; set; }
}
