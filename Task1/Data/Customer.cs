namespace Data
{
    internal class Customer 
    {
        private int Id { get; set; }
        private string Name { get; set; }

        internal Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            Customer? other = obj as Customer;
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