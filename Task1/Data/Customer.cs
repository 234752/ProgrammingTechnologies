namespace Data
{
    internal class Customer //maybe internal?
    {
        private int Id { get; set; }
        private string Name { get; set; }

        internal Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}