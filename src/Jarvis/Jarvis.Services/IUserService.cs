using Jarvis.DTOs;

namespace Jarvis.Services;

public interface IUserService
{
    //AuthenticateResponse? Authenticate(AuthenticateRequest model);
    User GetUser(string username,string password);

    IEnumerable<User> GetAll();
    User? GetById(int id);
}
