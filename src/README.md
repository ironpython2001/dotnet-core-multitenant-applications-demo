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

<<<<<<< Updated upstream
EF Core multitenancy
https://learn.microsoft.com/en-us/ef/core/miscellaneous/multitenancy
https://blog.jetbrains.com/dotnet/2022/06/22/multi-tenant-apps-with-ef-core-and-asp-net-core/
https://youssefsellami.com/implementing-multi-tenancy-with-entityframework-core/
https://medium.com/swlh/entity-framework-core-multitenancy-112d82cd89c6
https://www.codingame.com/playgrounds/5514/multi-tenant-asp-net-core-4---applying-tenant-rules-to-all-enitites
https://www.codingame.com/playgrounds/5518/multi-tenant-asp-net-core-5---implementing-database-per-tenant-strategy
https://github.com/Oriflame/EFCoreMultitenantSample
https://www.finbuckle.com/MultiTenant/Docs/v6.12.0/EFCore
https://www.carlrippon.com/creating-an-aspnetcore-multi-tenant-web-api-with-dapper-and-sql-rls/
=======
help:
>>>>>>> Stashed changes

