using Data;

namespace Logic
{
    public abstract class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateMyLogicLayer(DataLayerAbstractAPI data = default(DataLayerAbstractAPI)) //will it work as DI?
        {
            return new MyLogicLayer(data == null ? DataLayerAbstractAPI.CreateMyDataLayer() : data);
        }
        public abstract bool AddCustomer(int id, string name);
        public abstract int GetCustomerCount();
        public abstract bool RemoveCustomer(int customerIndex);
        public abstract bool RegisterDelivery(string date, int catalogNumberOfDeliveredProduct, int amount);
        public abstract bool RegisterSale(string date, int catalogNumberOfDesiredItem, int customerIndex);
        public abstract float CountRevenueFromSales();

        private class MyLogicLayer : LogicLayerAbstractAPI
        {
            public MyLogicLayer(DataLayerAbstractAPI dataLayer)
            {
                _dataLayer = dataLayer;
                _dataLayer.InitializeDataContext();
                _service = new Service(dataLayer);
            }
            private readonly DataLayerAbstractAPI _dataLayer;
            //service class here, TODO
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
            public override bool RegisterDelivery(string date, int catalogNumberOfDeliveredProduct, int amount)
            {
                return _service.RegisterDelivery(date, catalogNumberOfDeliveredProduct, amount);
            }
            public override bool RegisterSale(string date, int catalogNumberOfDesiredItem, int customerIndex)
            {
                return _service.RegisterSale(date, catalogNumberOfDesiredItem, customerIndex);
            }
            public override float CountRevenueFromSales()
            {
                return _service.CountRevenueFromSales();
            }
        }
    }
}
