using System.Collections;

namespace Data
{
    public class Customers : ICollection<Customer> //maybe internal?
    {
        List<Customer> CustomersList = new List<Customer>();
        public int Count => CustomersList.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Customer customer)
        {
            CustomersList.Add(customer);
        }

        public void Clear()
        {
            CustomersList.Clear();
        }

        public bool Contains(Customer customer)
        {
            return CustomersList.Contains(customer);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            CustomersList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customer customer)
        {
            return CustomersList.Remove(customer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
