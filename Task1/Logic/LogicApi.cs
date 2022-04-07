using Data;

namespace Logic
{
    public class LogicApi : DataLayerAPI
    {
        public LogicApi()
        {

        }
        public override void AddCatalog()
        {
            var catalog = new DiamondCatalog();
            catalog.AddDiamondEvent += Catalog_AddDiamondEvent;
            catalog.RemoveDiamondEvent += Catalog_RemoveDiamondEvent;

            StorageState.Add(catalog);
        }

        public override void AddDiamond()
        {
            if (SelectedDiamondCatalog != null)
                SelectedDiamondCatalog.AddDiamond(new Diamond(1, 1, QualityValue.VeryGood, ShapeValue.Pear));
        }
        public override void RemoveCatalog()
        {
            StorageState.Add(new DiamondCatalog());
        }

        public override void RemoveDiamond()
        {
            if (SelectedDiamondCatalog != null)
            {
                SelectedDiamondCatalog.RemoveDiamond(SelectedDiamond);
            }
        }

        private void Catalog_RemoveDiamondEvent(Diamond diamond)
        {
            // wywolany przy usuwanym diamencie 
        }

        private void Catalog_AddDiamondEvent(Diamond diamond)
        {
            //to do po dodaniu diamentu cos mozna zrobic
        }

        private void AssignEvents(DiamondCatalog dCatalog)
        {
            dCatalog.AddDiamondEvent += Catalog_AddDiamondEvent;
            dCatalog.RemoveDiamondEvent += Catalog_RemoveDiamondEvent;
        }

        private void RemoveEvents(DiamondCatalog dCatalog)
        {
            dCatalog.AddDiamondEvent -= Catalog_AddDiamondEvent;
            dCatalog.RemoveDiamondEvent -= Catalog_RemoveDiamondEvent;
        }
    }
}