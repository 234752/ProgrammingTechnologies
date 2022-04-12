using Data.API;

namespace Logic
{
    internal class Service
    {
        private DataLayerAbstractAPI _dataLayer;
        internal Service(DataLayerAbstractAPI dataLayer)
        {
            _dataLayer = dataLayer;
        }
        internal bool AddCustomer(int id, string name)
        {
            try
            {
                if (!_dataLayer.IsCustomerIdFree(id)) throw new Exception();
                else _dataLayer.AddCustomer(id, name);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal int GetCustomerCount()
        {
            return _dataLayer.GetCustomerCount();
        }
        internal bool RemoveCustomer(int customerIndex)
        {
            try
            {
                return _dataLayer.RemoveCustomer(customerIndex);
            }
            catch (Exception ex)
            {
                return false;
            }
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
        internal bool RegisterSale(string date, int catalogNumberOfDesiredItem, int customerIndex)
        {
            try
            {
                if (_dataLayer.GetAmountOfCatalogItem(catalogNumberOfDesiredItem) <= 0) return false;
                int storageIndexOfSoldItem = _dataLayer.GetStorageIndexOfCatalogItem(catalogNumberOfDesiredItem);
                _dataLayer.AddSoldEvent(date, storageIndexOfSoldItem, customerIndex);
                _dataLayer.RemoveStorageEntry(storageIndexOfSoldItem);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        internal float CountRevenueFromSales()
        {
            try
            {
                float revenue = 0;
                for (int i = 0; i < _dataLayer.GetCatalogSize(); i++)
                {
                    revenue += _dataLayer.GetSoldCount(i) * _dataLayer.GetPriceOfCatalogItem(i);
                }
                return revenue;
            }
            catch (Exception ex)
            {
                return 404;
            }
            
        }
    }
}
