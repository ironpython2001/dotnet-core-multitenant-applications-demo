USE Jarvis
GO

BEGIN
    IF ((SELECT temporal_type
    FROM sys.tables
    WHERE object_id = OBJECT_ID('dbo.AppUser', 'U')) = 2)
		BEGIN
        ALTER TABLE [dbo].[AppUser] SET (SYSTEM_VERSIONING = OFF)
    END
	ELSE
		BEGIN
        DROP TABLE IF EXISTS [dbo].[AppUser]
    END
END
GO

CREATE TABLE AppUser
(
    Id INT NOT NULL Identity(1,1) PRIMARY KEY CLUSTERED,
    Name NVARCHAR(50) NOT NULL,
    IsActive bit not NULL default 0,
    ValidFrom DATETIME2 GENERATED ALWAYS AS ROW START NOT NULL,
    ValidTo DATETIME2 GENERATED ALWAYS AS ROW END NOT NULL,
    PERIOD FOR SYSTEM_TIME (ValidFrom, ValidTo)
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = dbo.AppUserHistory));
