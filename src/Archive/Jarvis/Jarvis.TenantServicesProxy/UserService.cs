using Jarvis.DTOs;
using Microsoft.Extensions.Logging;
using Jarvis.Utils;
using Microsoft.Scripting.Hosting;
using System.Reflection;
using Jarvis.Tenant.BluePrints;
using System.Text.Encodings.Web;
using IronPython.Hosting;

namespace Jarvis.TenantServicesProxy;

public class UserService : IUserService
{
    private readonly ILogger<IUserService> _logger;

    public UserService(ILogger<IUserService> logger)
    {
        _logger = logger;
    }

    public User GetUser(string username, string password)
    {
        _logger.MyLogMessage(LogLevel.Information, "adfasdfadsfasd");
        //return GetUserPy(username, password);
        return GetUserUsingReflection(username, password);
    }


    private User GetUserUsingReflection(string username, string password)
    {
        //Jarvis.SampleTenant1.UserService i = new SampleTenant1.UserService(_logger);

        var assemblyName = "Jarvis.SampleTenant1";
        var className = "Jarvis.SampleTenant1.UserService";
        var requestObjectType = Type.GetType($"{className}, {assemblyName}");

        var args = new object[] { _logger };
        var iUserService = Activator.CreateInstance(requestObjectType!, args) as IUserService;
        var user = iUserService!.GetUser(username, password);

        // return null if user not found
        if (user == null)
            return null;
        else
            return user;
    }

    public dynamic GetUserPy(string username, string password)
    {
        var engine = Python.CreateEngine();
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserService.py");
        var source = engine.CreateScriptSourceFromFile(path);
        var scope = engine.CreateScope();
        source.Execute(scope);
        var classUserService = scope.GetVariable("UserService");
        var userServiceInstance = engine.Operations.CreateInstance(classUserService);
        dynamic result = userServiceInstance.GetUser(username, password);
        return result;
        
        
    }

    public IEnumerable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User? GetById(int id)
    {
        throw new NotImplementedException();
    }
}