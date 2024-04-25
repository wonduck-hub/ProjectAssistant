CREATE TABLE [dbo].[Lists]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(255) NOT NULL,
	[CreateUserId] NVARCHAR(450) NULL,
	[ModifiedUserId] NVARCHAR(450) NULL,
	[Created] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[Modified] DATETIMEOFFSET (7) NULL,
	[WorkspaceId] INT NOT NULL,
	[IsDeleted]      BIT                NOT NULL DEFAULT 0,
	FOREIGN KEY (WorkspaceId) REFERENCES Workspaces(Id)
)

