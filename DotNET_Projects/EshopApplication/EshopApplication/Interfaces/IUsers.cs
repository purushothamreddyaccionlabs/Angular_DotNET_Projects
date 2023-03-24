using EshopApplication.Models;
using Models;

namespace EshopApplication.Interfaces
{
    public interface IUsers
    {
        List<Users> GetUsersList();
        Users RegisterUser(Users userData);
        Users UpdateProfile(Users userData);
        Response ValidateUser(LoginUser userData);

    }
}
