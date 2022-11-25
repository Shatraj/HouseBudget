namespace HouseBudget.Data
{
    public class HouseBudgetService3
    {
        private static List<Entry3> fakeDb3 = new List<Entry3>();


        public async Task<bool> AddEntry3(Entry3 newEntry3)
        {
            fakeDb3.Add(newEntry3);
            return true;
        }

        public async Task<List<Entry3>> GetAllEntries3()
        {
            return fakeDb3;
        }
    }
}
