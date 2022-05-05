using Data.API;

namespace Logic.API
{
    public abstract class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateMyLogicLayer(DataLayerAbstractAPI data = default(DataLayerAbstractAPI)) 
        {
            return new MyLogicLayer(data == null ? DataLayerAbstractAPI.CreateMyDataLayer() : data);
        }
        public abstract bool AddCustomer(int id, string name);
        public abstract int GetCustomerCount();
        public abstract bool RemoveCustomer(int customerIndex);
        public abstract bool AddCatalogEntry(int catalogNumber, decimal carat, decimal price, int quality, int shape);
        public abstract bool RegisterDelivery(string date, int catalogNumberOfDeliveredProduct, int amount);
        public abstract bool RegisterSale(string date, int catalogNumberOfDesiredItem, int customerIndex);
        public abstract decimal CountRevenueFromSales();

        private class MyLogicLayer : LogicLayerAbstractAPI
        {
            public MyLogicLayer(DataLayerAbstractAPI dataLayer)
            {
                _dataLayer = dataLayer;
                _dataLayer.InitializeCatalog();
                _service = new Service(dataLayer);
            }
            private readonly DataLayerAbstractAPI _dataLayer;

            private Service _service;

            public override bool AddCustomer(int id, string name)
            {
                return _service.AddCustomer(id, name);
            }

            public override int GetCustomerCount()
            {
                return _service.GetCustomerCount();
            }
            public override bool RemoveCustomer(int customerIndex)
            {
                return _service.RemoveCustomer(customerIndex);
            }
            public override bool AddCatalogEntry(int catalogNumber, decimal carat, decimal price, int quality, int shape)
            {
                return _service.AddCatalogEntry(catalogNumber, carat, price, quality, shape);
            }
            public override bool RegisterDelivery(string date, int catalogNumberOfDeliveredProduct, int amount)
            {
                return _service.RegisterDelivery(date, catalogNumberOfDeliveredProduct, amount);
            }
            public override bool RegisterSale(string date, int catalogNumberOfDesiredItem, int customerIndex)
            {
                return _service.RegisterSale(date, catalogNumberOfDesiredItem, customerIndex);
            }
            public override decimal CountRevenueFromSales()
            {
                return _service.CountRevenueFromSales();
            }
        }
    }
}
