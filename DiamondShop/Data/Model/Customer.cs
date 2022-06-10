using Data.API;

namespace Data.Model;
public class Customer : ICustomer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    internal Customer(int id, string name, string surname)
    {
        CustomerId = id;
        Name = name;
        Surname = surname; 
    }
    internal Customer() { }
}