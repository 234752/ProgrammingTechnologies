using Data;

namespace Logic
{
    public abstract class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateMyLogicLayer(DataLayerAbstractAPI data = default(DataLayerAbstractAPI)) //will it work as DI?
        {
            return new MyLogicLayer(data == null ? DataLayerAbstractAPI.CreateMyDataLayer() : data);
        }

        private class MyLogicLayer : LogicLayerAbstractAPI
        {
            public MyLogicLayer(DataLayerAbstractAPI dataLayer)
            {
                _dataLayer = dataLayer;
                _dataLayer.InitializeDataContext();
            }
            private readonly DataLayerAbstractAPI _dataLayer;
            //service class here, TODO
        }
    }
}
