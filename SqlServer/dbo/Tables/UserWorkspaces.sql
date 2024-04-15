CREATE TABLE [dbo].[UserWorkspaces]
(
    [Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [AspNetUsersId] NVARCHAR(450) NOT NULL,
    [WorkspaceId] INT NOT NULL,
    FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].[Workspaces] ([Id]),
    FOREIGN KEY ([AspNetUsersId]) REFERENCES [dbo].AspNetUsers ([Id]),
    CONSTRAINT UC_UserWorkspace UNIQUE (AspNetUsersId, WorkspaceId)
)

