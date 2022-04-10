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
        internal bool RegisterDelivery(string date, int catalogNumberOfDeliveredProduct, int amount)
        {
            try
            {
                for (int i = 0; i < amount; i++)
                {
                    _dataLayer.AddStorageEntry(catalogNumberOfDeliveredProduct);
                    _dataLayer.AddDeliveryEvent(date, _dataLayer.GetAmountOfAllItems() - 1);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
