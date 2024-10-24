CREATE TABLE [dbo].[PersonalSchedule]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(255) NOT NULL,
	[StartDate] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[EndDate] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[IsSuccess] BIT DEFAULT(0) NOT NULL,
	[SuccessDate] DATETIMEOFFSET (7) NULL,
	[CreateUserId] NVARCHAR(450) NULL,
	[ModifiedUserId] NVARCHAR(450) NULL,
	[TaskDetails] NVARCHAR(500) NULL,
	[Created] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[Modified] DATETIMEOFFSET (7) NULL,
	[UserId] NVARCHAR (450) NOT NULL,
	[IsDeleted]      BIT                NOT NULL DEFAULT 0,
	FOREIGN KEY (UserId) REFERENCES AspNetUsers(Id)
)
