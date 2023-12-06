using Jarvis.DTOs;
using Microsoft.Extensions.Logging;
using Jarvis.Utils;
using Jarvis.Tenant.BluePrints;
using IronPython.Hosting;

namespace Jarvis.SampleTenant1;

public class UserService : IUserService
{
    // users hardcoded for simplicity, store in a db with hashed passwords in production applications
    private List<User> _users = new List<User>
    {
        new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
    };

    private readonly ILogger<IUserService> _logger;

    public UserService(ILogger<IUserService> logger)
    {
        _logger = logger;
    }
    //public UserService()
    //{
        
    //}

    //public AuthenticateResponse? Authenticate(AuthenticateRequest model)
    //{
    //    var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

    //    // return null if user not found
    //    if (user == null) return null;

    //    // authentication successful so generate jwt token
    //    var token = _jwtUtils.GenerateJwtToken(user);

    //    return new AuthenticateResponse(user, token);
    //}

    public User GetUser(string username, string password)
    {
        _logger.MyLogMessage(LogLevel.Information, "adfasdfadsfasd");

        //GetUserPy(username, password);  

        var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

        // return null if user not found
        if (user == null)
            return null;
        else
            return user;



    }

    public void GetUserPy(string username, string password)
    {
        var engine = Python.CreateEngine();
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sample.py");
        var source = engine.CreateScriptSourceFromFile(path);
        var scope = engine.CreateScope();
        source.Execute(scope);
        var classCalculator = scope.GetVariable("calculator");
        var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
        Console.WriteLine("From Iron Python");
        Console.WriteLine("5 + 10 = {0}", calculatorInstance.add(5, 10));
        Console.WriteLine("5++ = {0}", calculatorInstance.increment(5));
    }

    public IEnumerable<User> GetAll()
    {
        return _users;
    }

    public User? GetById(int id)
    {
        return _users.FirstOrDefault(x => x.Id == id);
    }
}