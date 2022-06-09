
namespace Data.API;

public interface ICustomer
{
    int CustomerId { get; }
    string Name { get; set; }
    string Surname { get; set; }
}
