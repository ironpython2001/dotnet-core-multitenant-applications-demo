using FluentValidation;
using Jarvis.DTOs;
using Jarvis.Tenant.BluePrints;
using Jarvis.WebApi;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.OpenApi.Models;
using Serilog;
using Jarvis.DTOValidations;
using Jarvis.TenantServicesProxy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpLogging(httpLogging =>
{
    //TODO: NEED TO CUSTOMIZE THIS BASED ON THE NEEDS
    httpLogging.LoggingFields = HttpLoggingFields.All;
    //httpLogging.RequestHeaders.Add("Request-Header-Demo");
    //httpLogging.ResponseHeaders.Add("Response-Header-Demo");
    //httpLogging.MediaTypeOptions.AddText("application/javascript");
    //httpLogging.RequestBodyLogLimit = 4096;
    //httpLogging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddSerilog(lc =>
{
    lc.MinimumLevel.Debug()
    .WriteTo.Console()
    //.WriteTo.File(path: builder.Configuration["LogInformation:path"], outputTemplate: builder.Configuration["LogInformation:outputTemplate"], retainedFileCountLimit: 10, rollingInterval: RollingInterval.Day)
    .Enrich.FromLogContext()
    //.Enrich.WithMachineName()
    .Enrich.WithCorrelationId();
});
builder.Services.AddHttpContextAccessor();
//builder.Services.AddHeaderPropagation(options => options.Headers.Add("jarviscorrelationid"));
//builder.Services.AddHttpClient().AddHeaderPropagation();
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
var openApiSecuritySchema = new OpenApiSecurityScheme()
{
    Name = "Authorization",
    Type = SecuritySchemeType.ApiKey,
    Scheme = "Bearer",
    BearerFormat = "JWT",
    In = ParameterLocation.Header,
    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
};

var openApiSecurityRequirement = new OpenApiSecurityRequirement
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        new string[] {}
    }
};

builder.Services.AddSwaggerGen(swagger =>
{
    swagger.AddSecurityDefinition("Bearer", securityScheme: openApiSecuritySchema);
    swagger.AddSecurityRequirement(securityRequirement: openApiSecurityRequirement);
});

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddScoped<IValidator<AuthenticateRequest>, AuthenticateRequestValidator>();
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
