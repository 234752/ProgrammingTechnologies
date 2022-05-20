using Data.API;

namespace Data

{
    internal class Customer : ICustomer
    {
    private int Id;
    private string Name;

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

    int ICustomer.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    string ICustomer.Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

      
        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int GetId()
        {
            return Id;
        }
    }
}