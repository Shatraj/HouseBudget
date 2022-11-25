namespace HouseBudget.Data
{
    public class HouseBudgetService2
    {
        private static List<Entry2> fakeDb2 = new List<Entry2>();


        public async Task<bool> AddEntry2(Entry2 newEntry2)
        {
            fakeDb2.Add(newEntry2);
            return true;
        }

        public async Task<List<Entry2>> GetAllEntries2()
        {
            return fakeDb2;
        }
    }
}
