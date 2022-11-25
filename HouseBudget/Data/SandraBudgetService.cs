namespace HouseBudget.Data
{
    public class SandraBudgetService
    {
        private static List<Sandra> fakeDbSandra = new List<Sandra>()
        {
            new Sandra() { Id = 501,Description = "Cement", Unit = "Tone", Quantity = 29.98, Price = 60269.80, Date = "21/02/2022" },
           new Sandra() { Id = 224,Description = "Cement", Unit = "Tone", Quantity = 30.06, Price = 2677.99, Date = "24/02/2022" }
            };
        public async Task<bool> addSandraEntry(Sandra sandra)
        {
            fakeDbSandra.Add(sandra);
            return true;
        }
        public async Task<List<Sandra>> GetSandras()
        {
            return fakeDbSandra;
        }
    }
}
