-- ALTER TABLE [dbo].[Tenant] SET ( SYSTEM_VERSIONING = OFF)
-- GO
-- DROP TABLE [dbo].[Tenant]
-- GO
-- DROP TABLE [dbo].[TenantHistory]
-- GO

/*
connection string
Server=tcp:myosisqlserver.database.windows.net,1433;Initial Catalog=mySampleDatabase;Persist Security Info=False;User ID=azureuser;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
*/

CREATE SCHEMA Admin
CREATE TABLE Admin.Tenant
(
    TenantID INT NOT NULL IDENTITY PRIMARY KEY CLUSTERED ,
    TenantName VARCHAR(10) NOT NULL,
    Identifier VARCHAR(50) NOT NULL,
	StartTime datetime2 GENERATED ALWAYS AS ROW START NOT NULL,
	EndTime datetime2 GENERATED ALWAYS AS ROW END NOT NULL,
	PERIOD FOR SYSTEM_TIME (StartTime,EndTime)
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = Admin.TenantHistory));



