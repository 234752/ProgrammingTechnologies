namespace Data
{
    internal class StorageEntry
    { //represents single diamond that is in the storage and avaiable for customers
        internal int _catalogNumber;

        internal StorageEntry(int catalogNumber)
        {
            _catalogNumber = catalogNumber;
        }
        internal int getCatalogNumber()
        {
            return _catalogNumber;
        }
    }
}
