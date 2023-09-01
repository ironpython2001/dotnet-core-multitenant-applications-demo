requirements:

visual studio 2022 with .net 7

steps to run the application
1. from cmd navigate to "DemoComp.MultiTenantApp.Api" project directory
2. at cmd execute the command "dotnet build"
3. at cmd execute the command "dotnet run --launch-profile https."
4. at cmd
curl --location 'https://localhost:7147/Tenant' \
--header 'tenant: megacorp'

reference URLs:

1. https://github.com/dotnet/sdk/issues/29569
2. https://medium.com/@zahidcakici/multitenancy-and-finbukcle-in-net-f1d5e7e5f1bf
3. https://www.finbuckle.com/MultiTenant
4. https://www.finbuckle.com/MultiTenant/Docs/v6.12.0/Strategies
5. https://github.com/zahidcakici/MultitenantFinbuckleExample/blob/master/Program.cs
6. https://www.finbuckle.com/MultiTenant
7. https://github.com/Finbuckle/Finbuckle.MultiTenant/blob/main/samples/net6.0/BasePathStrategySample/appsettings.json

