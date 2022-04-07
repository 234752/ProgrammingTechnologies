namespace Data
{
    internal class Order //List of orders in StorageState?
    {
        private string Date;
        private Customer Customer;
        private List<Diamond> OrderedDiamonds = new List<Diamond>();

        public Order(Customer customer, string date)
        {
            this.Customer = customer;
            this.Date = date;
        }
        public void AddToOrder(Diamond diamond)
        {
            if (OrderedDiamonds != null)// czy jakis wyjatek throw exceptions 
                throw new ArgumentNullException($"Nie przekazano diamendu z ID: {diamond.Id}");
            
            OrderedDiamonds.Add(diamond);
        }
    }
}