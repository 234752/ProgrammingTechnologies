namespace Data
{
    internal class Event
    {
        private string date;
        private List<Diamond> removedFromStorage = new List<Diamond>();
        private List<Diamond> addedToStorage = new List<Diamond>();

        public Event(string date)
        {
            this.date = date;
        }

        public void NoteRemovedDiamond(Diamond diamond)
        {
            removedFromStorage.Add(diamond);
        }
        public void NoteAddedDiamond(Diamond diamond)
        {
            addedToStorage.Add(diamond);
        }
    }
}