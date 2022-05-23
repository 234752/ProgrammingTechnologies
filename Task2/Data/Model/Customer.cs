using Data.API;

namespace Data.Model

{
    public class Customer : ICustomer
    {
    public int CustomerId { get; set; }
    public string Name { get; set; }
     public string Surname { get; set; }

        public Customer(int id, string name, string surname)
        {
            CustomerId = id;
            Name = name;
            Surname = surname; 
        }


      
        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int GetId()
        {
            return CustomerId;
        }
    }
}