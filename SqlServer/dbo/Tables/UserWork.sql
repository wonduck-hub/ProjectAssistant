﻿CREATE TABLE [dbo].[UserWork]
(
	[Id]            INT            IDENTITY (1, 1) NOT NULL,
	[WorkId] INT NOT NULL,
	[UserId] NVARCHAR(450) NOT NULL,
	[WorkspaceId] INT NOT NULL,
	FOREIGN KEY ([WorkId]) REFERENCES [dbo].Works ([Id]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].AspNetUsers ([Id]),
	FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].Workspaces ([Id]),
	CONSTRAINT UC_UserWork UNIQUE (WorkId, UserId, WorkspaceId),
)
