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

    public override bool Equals(object obj)
        {
            Customer other = obj as Customer;
            return this.Id == other.Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        internal int GetId()
        {
            return Id;
        }
    }
}