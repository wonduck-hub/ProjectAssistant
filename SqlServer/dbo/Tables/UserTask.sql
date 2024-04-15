CREATE TABLE [dbo].[TaskUser]
(
	[Id]            INT            IDENTITY (1, 1) NOT NULL,
	[TaskId] INT NOT NULL,
	[UserId] NVARCHAR(450) NOT NULL,
	FOREIGN KEY ([TaskId]) REFERENCES [dbo].Tasks ([Id]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].AspNetUsers ([Id]),
)
