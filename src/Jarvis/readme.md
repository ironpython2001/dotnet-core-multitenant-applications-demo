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

asp.net correleationid generation
https://github.com/skwasjer/Correlate

Store JSON documents in SQL Server or SQL Database
https://learn.microsoft.com/en-us/sql/relational-databases/json/store-json-documents-in-sql-tables?view=sql-server-ver16

SQL Server JSON Data Type
https://linuxhint.com/sql-server-json-data-type/

ASP.NET CORE CORRELATION IDS
https://www.stevejgordon.co.uk/asp-net-core-correlation-ids

ironpython integration with dotnet core 
https://www.dotnetlovers.com/article/216/executing-python-script-from-c-sharp
https://k23-software.net/csharp-ironpython-tutorial
https://jonwood.co/blog/2013/08/21/learning-python-using-ironpython
https://putridparrot.com/blog/hosting-ironpython-in-a-c-application/


Logging in .NET Core without DI
https://stackoverflow.com/questions/53235472/logging-in-net-core-without-di

how-to-pass-logger-object-while-creating-instance-using-reflection
https://stackoverflow.com/questions/72109637/how-to-pass-logger-object-while-creating-instance-using-reflection


How to invoke C#/.NET namespace in IronPython?
https://stackoverflow.com/questions/7719397/how-to-invoke-c-net-namespace-in-ironpython

How to load DLL using Iron python?
https://stackoverflow.com/questions/18427775/how-to-load-dll-using-iron-python

How to add a .Net assembly as reference in IronPython
https://codeyarns.com/tech/2013-06-07-how-to-add-a-net-assembly-as-reference-in-ironpython.html#gsc.tab=0


How do you implement an interface in IronPython?
https://stackoverflow.com/questions/695986/how-do-you-implement-an-interface-in-ironpython#:~:text=The%20FAQ%20that%20comes%20with,the%20interfaces%20to%20C%23%20code.

can you typecast a .NET object in IronPython?
https://stackoverflow.com/questions/1439457/can-you-typecast-a-net-object-in-ironpython


DapperDotNet w/IronPython: How To Handle Returned Result Set?
https://stackoverflow.com/questions/12845992/dapperdotnet-w-ironpython-how-to-handle-returned-result-set


IronPython using Dapper.NET (w/MySql backend and stored procedures)
https://gist.github.com/WillSams/3873014