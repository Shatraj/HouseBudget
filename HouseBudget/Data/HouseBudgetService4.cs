namespace HouseBudget.Data
{
    public class HouseBudgetService4
    {
        private static List<Entry4> fakeDb4 = new List<Entry4>();


        public async Task<bool> AddEntry4(Entry4 newEntry4)
        {
            fakeDb4.Add(newEntry4);
            return true;
        }

        public async Task<List<Entry4>> GetAllEntries4()
        {
            return fakeDb4;
        }
    }
}
