CREATE TABLE [dbo].[Chats]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[Text] NVARCHAR(255) NOT NULL,
	[IsImage] BIT NOT NULL DEFAULT 0,
	[Created] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[Modified] DATETIMEOFFSET (7) NULL,
	[IsDeleted]      BIT                NOT NULL DEFAULT 0,
	[IsNotification]      BIT                NOT NULL DEFAULT 0,
	[ChatRoomId] INT NOT NULL,
	[UserId] NVARCHAR (450) NOT NULL,
	FOREIGN KEY (ChatRoomId) REFERENCES ChatRooms(Id),
	FOREIGN KEY (UserId) REFERENCES AspNetUsers(Id)
)
