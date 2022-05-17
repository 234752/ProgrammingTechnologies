namespace Data
{
    internal class StorageEntry //do we still need this class? sell/delivery events can refer directly to catalog items
    { //represents single diamond that is in the storage and avaiable for customers
        internal int _catalogNumber;

        internal StorageEntry(int catalogNumber)
        {
            _catalogNumber = catalogNumber;
        }
        internal int GetCatalogNumber()
        {
            return _catalogNumber;
        }
    }
}
