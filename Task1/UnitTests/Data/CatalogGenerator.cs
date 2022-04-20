using Data.API;

namespace UnitTests.Data
{
    internal class CatalogGenerator : IGenerator
    {
        void IGenerator.GenerateData(DataLayerAbstractAPI dataLayer)
        {
            dataLayer.AddCatalogEntry(0, 1F, 2999.99F, 1, 1);
            dataLayer.AddCatalogEntry(1, 1F, 3999.99F, 2, 2);
            dataLayer.AddCatalogEntry(2, 2F, 4999.99F, 3, 3);
            dataLayer.AddCatalogEntry(3, 2F, 6999.99F, 3, 4);
            dataLayer.AddCatalogEntry(3, 3F, 1999.99F, 4, 4);
        }
    }
}
