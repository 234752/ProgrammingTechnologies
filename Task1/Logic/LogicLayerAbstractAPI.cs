using Data;

namespace Logic
{
    public abstract class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateMyLogicLayer(DataLayerAbstractAPI data = default(DataLayerAbstractAPI)) //will it work as DI?
        {
            return new MyLogicLayer(data == null ? DataLayerAbstractAPI.CreateMyDataLayer() : data);
        }
        public abstract void AddCustomer(int id, string name);
        public abstract int GetCustomerCount();
        public abstract bool RemoveCustomer(int customerIndex);

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

            public override void AddCustomer(int id, string name)
            {
                _service.AddCustomer(id, name);
            }

            public override int GetCustomerCount()
            {
                return _service.GetCustomerCount();
            }
            public override bool RemoveCustomer(int customerIndex)
            {
                return _service.RemoveCustomer(customerIndex);
            }
        }
    }
}
