Requirements:

visual studio 2022 with .net 7

steps to run the application
1. from cmd navigate to "Jarvis.WebApi" project directory
2. at cmd execute the command "dotnet build"
3. at cmd execute the command "dotnet run --launch-profile https"
4. at cmd
curl --location 'https://localhost:7147/Tenant' \
--header 'tenant: megacorp'

References:

.NET 7.0 + C# - JWT Authentication Tutorial without ASP.NET Core Identity
https://jasonwatmore.com/net-7-csharp-jwt-authentication-tutorial-without-aspnet-core-identity
	
Custom JWT Handler In ASP.Net Core 7 Web API
https://www.c-sharpcorner.com/article/custom-jwt-handler-in-asp-net-core-7-web-api/

.NET 7 Web API JWT Authentication and role-based Authorization
https://shahedbd.medium.com/net-7-web-api-jwt-authentication-and-role-based-authorization-f2ff81f69cd4

JWT Authentication Configuration in Dotnet 7
https://dottutorials.net/jwt-authentication-configuration-in-asp-net-7/

Authentication And Authorization In .NET Core Web API Using JWT Token And Swagger UI
https://www.c-sharpcorner.com/article/authentication-authorization-using-net-core-web-api-using-jwt-token-and/

Configure Swagger to accept Header Authorization
https://www.freecodespot.com/blog/use-jwt-bearer-authorization-in-swagger/

Http Logging in .net 7
https://www.learmoreseekmore.com/2021/12/dotnet6-http-logs-with-usehttplogging-middleware.html

use serilog with httplogging
https://stackoverflow.com/questions/63573551/how-to-add-request-body-in-serilogs-output-net-core

How to log Correlation IDs in .NET APIs with Serilog
https://www.code4it.dev/blog/serilog-correlation-id/

Easy ASP.NET log correlation with Serilog and Seq
https://nblumhardt.com/2014/02/easy-asp-net-log-correlation/