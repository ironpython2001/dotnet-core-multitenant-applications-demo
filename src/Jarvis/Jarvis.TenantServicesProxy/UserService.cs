using Jarvis.DTOs;
using Microsoft.Extensions.Logging;
using Jarvis.Utils;
using Microsoft.Scripting.Hosting;
using System.Reflection;
using Jarvis.Tenant.BluePrints;
using System.Text.Encodings.Web;

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

    public IEnumerable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User? GetById(int id)
    {
        throw new NotImplementedException();
    }
}