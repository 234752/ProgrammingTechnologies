using Data.API;

namespace Data
{
    internal class EmptyGenerator : IGenerator
    {
        void IGenerator.GenerateData(DataLayerAbstractAPI dataLayer) { }
    }
}
