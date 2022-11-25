namespace HouseBudget.Data
{
    public class HouseBudgetService
    {

        private static List<Entry> fakeDb = new List<Entry>()
        {
           new Entry(){Id=241,Description="Granulated-Stone2", Unit="m2", Quantity=15, Price=60, Date="21/02/2022" },
           new Entry(){Id=255,Description="Granulated-Stone2", Unit="m2", Quantity=15, Price=60, Date="24/02/2022" }
        };

        public async Task<bool> AddEntry(Entry newEntry)
        {
            fakeDb.Add(newEntry);
            return true;
        }

        public async Task<List<Entry>> GetAllEntries()
        {
            return fakeDb;
        }
    }
}

