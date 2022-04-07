using System.Collections;

namespace Data
{
    public class StorageState: ICollection<DiamondCatalog> //idk if this is correct here
    {
        List<Order> OrderList = new List<Order>();
        

        public IEnumerator<DiamondCatalog> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(DiamondCatalog item)
        {
            Add(item);
        }
        
        

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(DiamondCatalog item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(DiamondCatalog[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(DiamondCatalog item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
    }
