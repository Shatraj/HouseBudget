namespace HouseBudget.Data
{
    public class HouseBudgetService1
    {
        private static List<Entry1> fakeDb1 = new List<Entry1>();
       

        public async Task<bool> AddEntry1(Entry1 newEntry1)
        {
            fakeDb1.Add(newEntry1);
            return true;
        }

        public async Task<List<Entry1>> GetAllEntries1()
        {
            return fakeDb1;
        }
    }
}
