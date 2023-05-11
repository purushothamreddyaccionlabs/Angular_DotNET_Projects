using HSPAWebAPI.Data.Repo;
using HSPAWebAPI.Interfaces;

namespace HSPAWebAPI.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext db;
        public UnitOfWork(DataContext db)
        {
            this.db = db;
        }
        public ICityRepository CityRepository => new CityRepository(db);

        public async Task<bool> SaveAsync()
        {
            return await db.SaveChangesAsync() > 0;
        }
    }
}
