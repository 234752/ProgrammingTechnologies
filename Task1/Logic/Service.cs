using Data;

namespace Logic
{
    internal class Service //whole logic should be in this class
    {
        private DataLayerAbstractAPI _dataLayer;
        internal Service(DataLayerAbstractAPI dataLayer)
        {
            _dataLayer = dataLayer;
        }
        internal void AddCustomer(int id, string name)
        {
            _dataLayer.AddCustomer(id, name);
        }
        internal int GetCustomerCount()
        {
            return _dataLayer.GetCustomerCount();
        }
        internal bool RemoveCustomer(int customerIndex)
        {
            return _dataLayer.RemoveCustomer(customerIndex);
        }
    }
}
