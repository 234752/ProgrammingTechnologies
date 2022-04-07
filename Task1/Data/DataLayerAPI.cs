namespace Data
{
    public abstract class DataLayerAPI
    {
        private StorageState _storageState;
        private Customer Customer;
        private DiamondCatalog DiamondCatalog;
        public DiamondCatalog SelectedDiamondCatalog { get; set; }
       // public Diamond SelectedDiamond { get; set; } commented due to diamond protection
        public DataLayerAPI()
        {
            _storageState = new StorageState();
        }

        public StorageState StorageState => _storageState;

        public virtual void AddCatalog() { }

        public virtual void AddDiamond() { }
        public virtual void RemoveCatalog() { }

        public virtual void RemoveDiamond() { }
    }
}