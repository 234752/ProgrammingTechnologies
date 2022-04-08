namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract void Connect();

        public static DataLayerAbstractAPI CreateMyDataLayer()
        {
            return new MyDataLayer();
        }

        #region Layer implementation

        private class MyDataLayer : DataLayerAbstractAPI
        {
            public override void Connect()
            {
                DataContext myData = new DataContext();
            }

            #endregion Layer implementation
        }
    }
}