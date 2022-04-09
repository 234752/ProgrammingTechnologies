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
        internal void addCustomer(int id, string name)
        {
            _dataLayer.addCustomer(id, name);
        }
        internal int getCustomerCount()
        {
            return _dataLayer.getCustomerCount();
        }
    }
}
