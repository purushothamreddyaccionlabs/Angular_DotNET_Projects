using HSPAWebAPI.Models;

namespace HSPAWebAPI.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Authenticate(string userName, string password);
    }
}
