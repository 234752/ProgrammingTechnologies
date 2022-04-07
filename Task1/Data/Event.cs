namespace Data
{
    internal class Event
    {
        private string Date;
        private List<Diamond> RemovedFromStorage = new List<Diamond>();
        private List<Diamond> AddedToStorage = new List<Diamond>();

        public Event(string date)
        {
            this.Date = date;
        }

        public void NoteRemovedDiamond(Diamond diamond)
        {
            RemovedFromStorage.Add(diamond);
        }
        public void NoteAddedDiamond(Diamond diamond)
        {
            AddedToStorage.Add(diamond);
        }
    }
}