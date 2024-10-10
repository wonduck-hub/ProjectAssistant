CREATE TABLE [dbo].[Votes]
(
	Id INT PRIMARY KEY IDENTITY (1, 1),
    VotsId INT NOT NULL,
    UserId NVARCHAR (450)     NOT NULL,
    VoteType BIT NOT NULL, -- '찬성' 또는 '반대'
    [Created] DATETIMEOFFSET (7) DEFAULT ((sysdatetimeoffset() AT TIME ZONE 'Korea Standard Time')) NULL,
	[Modified] DATETIMEOFFSET (7) NULL,
	[IsDeleted]      BIT                NOT NULL DEFAULT 0,
    FOREIGN KEY (VotsId) REFERENCES Vots(Id),
    FOREIGN KEY (UserId) REFERENCES AspNetUsers(Id)
)
