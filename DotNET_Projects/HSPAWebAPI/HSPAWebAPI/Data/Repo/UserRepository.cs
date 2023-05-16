using HSPAWebAPI.Interfaces;
using HSPAWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HSPAWebAPI.Data.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext db;
        public UserRepository(DataContext db)
        {
            this.db = db;
        }
        public async Task<User> Authenticate(string userName, string password)
        {
            return await db.Users.FirstOrDefaultAsync(x => x.Username == userName && x.Password == password);

        }
    }
}
