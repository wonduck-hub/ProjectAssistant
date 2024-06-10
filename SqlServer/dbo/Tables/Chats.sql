﻿CREATE TABLE [dbo].[Chats]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Text] NVARCHAR(255) NOT NULL,
	[Created] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[Modified] DATETIMEOFFSET (7) NULL,
	[IsDeleted]      BIT                NOT NULL DEFAULT 0,
	[IsNotification]      BIT                NOT NULL DEFAULT 0,
	[WorkspacesId] INT NOT NULL,
)
