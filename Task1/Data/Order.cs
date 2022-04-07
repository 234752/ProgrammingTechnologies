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
            OrderedDiamonds.Add(diamond);
        }
    }
}