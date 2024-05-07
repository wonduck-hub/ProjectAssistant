CREATE TABLE [dbo].[WorkspaceWork]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [WorkId] INT NOT NULL,
    [WorkspaceId]   INT            NOT NULL,
    FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].[Workspaces] ([Id]),
    FOREIGN KEY ([WorkId]) REFERENCES [dbo].[Works] ([Id]),
)
