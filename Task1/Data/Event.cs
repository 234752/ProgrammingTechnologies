namespace Data
{
    internal class Event //this class must be abstract
    {
        private string Date;
        private List<Diamond> RemovedFromStorage = new List<Diamond>();
        private List<Diamond> AddedToStorage = new List<Diamond>();
        
        internal Event(string date)
        {
            this.Date = date;
        }

        internal void NoteRemovedDiamond(Diamond diamond)
        {
            RemovedFromStorage.Add(diamond);
        }
        internal void NoteAddedDiamond(Diamond diamond)
        {
            AddedToStorage.Add(diamond);
        }
    }
}