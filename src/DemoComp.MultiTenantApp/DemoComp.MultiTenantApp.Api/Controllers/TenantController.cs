using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Mvc;

namespace DemoComp.MultiTenantApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TenantController : ControllerBase
    {

        private readonly ILogger<TenantController> _logger;

        public TenantController(ILogger<TenantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTenantInfo")]
        public TenantInfo? Get()
        {
            var tenantInfo = HttpContext.GetMultiTenantContext<TenantInfo>()?.TenantInfo;
            if (tenantInfo is not null)
                return tenantInfo;
            else
                return null;
        }
    }
}