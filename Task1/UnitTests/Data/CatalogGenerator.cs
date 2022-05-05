using Data.API;

namespace UnitTests.Data
{
    internal class CatalogGenerator : IGenerator
    {
        void IGenerator.GenerateData(DataLayerAbstractAPI dataLayer)
        {
            dataLayer.AddCatalogEntry(0, 1M, 2999.99M, 1, 1);
            dataLayer.AddCatalogEntry(1, 1M, 3999.99M, 2, 2);
            dataLayer.AddCatalogEntry(2, 2M, 4999.99M, 3, 3);
            dataLayer.AddCatalogEntry(3, 2M, 6999.99M, 3, 3);
            dataLayer.AddCatalogEntry(4, 3M, 1999.99M, 3, 3);
        }
    }
}
