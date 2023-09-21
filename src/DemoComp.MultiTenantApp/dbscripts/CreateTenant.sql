-- ALTER TABLE [Admin].[Tenant] SET ( SYSTEM_VERSIONING = OFF)
-- GO
-- DROP TABLE [Admin].[Tenant]
-- GO
-- DROP TABLE [Admin].[TenantHistory]
-- GO

/*
connection string
Server=tcp:myosisqlserver.database.windows.net,1433;Initial Catalog=mySampleDatabase;Persist Security Info=False;User ID=azureuser;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
*/

-- CREATE SCHEMA Admin;
CREATE TABLE Admin.Tenant
(
    _id BIGINT NOT NULL IDENTITY PRIMARY KEY CLUSTERED ,
    JsonDoc NVARCHAR(4000),
    IsActive BIT NOT NULL DEFAULT 0,
    CreatedBy  NVARCHAR(100) NOT NULL,
    CreatedTime  DATETIME NOT NULL,
    ModifiedBy  NVARCHAR(100) NOT NULL,
    ModifiedTime  DATETIME NOT NULL,
    StartTime datetime2 GENERATED ALWAYS AS ROW START NOT NULL,
	EndTime datetime2 GENERATED ALWAYS AS ROW END NOT NULL,
	PERIOD FOR SYSTEM_TIME (StartTime,EndTime)
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = Admin.TenantHistory));



