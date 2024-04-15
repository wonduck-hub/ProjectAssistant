CREATE TABLE [dbo].[WorkspaceUser]
(
	[Id]            INT            IDENTITY (1, 1) NOT NULL,
    [AspNetUsersId] NVARCHAR (450) NOT NULL,
    [WorkspaceId]   INT            NOT NULL,
    FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].[Workspaces] ([Id]),
    FOREIGN KEY ([AspNetUsersId]) REFERENCES [dbo].AspNetUsers ([Id]),
)
