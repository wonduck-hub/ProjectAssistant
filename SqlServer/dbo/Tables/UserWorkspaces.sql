CREATE TABLE [dbo].[UserWorkspaces]
(
	[AspNetUsersId] NVARCHAR(450) NOT NULL,
	[WorkspaceId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([AspNetUsersId] ASC, [WorkspaceId] ASC),
	FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].[Workspaces] ([Id]),
	FOREIGN KEY ([AspNetUsersId]) REFERENCES [dbo].AspNetUsers ([Id]),
)
