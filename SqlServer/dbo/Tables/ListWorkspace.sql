CREATE TABLE [dbo].[ListWorkspace]
(
	[Id]            INT            IDENTITY (1, 1) NOT NULL,
	[ListId] INT NOT NULL,
	[WorkspaceId] INT NOT NULL,
	FOREIGN KEY ([ListId]) REFERENCES [dbo].Lists ([Id]),
    FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].Workspaces ([Id]),
)
