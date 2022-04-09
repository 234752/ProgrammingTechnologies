using Data;

public class LogicApi { }
/*
namespace Logic
{
    public class LogicApi : DataLayerAPI
    {
        public LogicApi()
        {

        }

        public void AddOrder()
        {
            StorageState.AddOrder(SelectedDiamond);
        }

        public override void AddCatalog()
        {
            var catalog = new DiamondCatalog();
            AssignEvents(catalog);
            StorageState.Add(catalog);
        }

        public override void AddDiamond()
        {
            if (SelectedDiamondCatalog != null)
                SelectedDiamondCatalog.AddDiamond(new Diamond(1, 1, QualityValue.VeryGood, ShapeValue.Pear));
            // i dodac funkcje Equals jak bedzie implementowana
        }

        public override void RemoveCatalog()
        {
            if (SelectedDiamondCatalog != null)
            {
                StorageState.Remove(SelectedDiamondCatalog);
                RemoveEvents(SelectedDiamondCatalog);
            }
        }

        public override void RemoveDiamond()
        {
            if (SelectedDiamondCatalog != null && SelectedDiamondCatalog.Diamonds != null)
                SelectedDiamondCatalog.RemoveDiamond(SelectedDiamond);
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
*/