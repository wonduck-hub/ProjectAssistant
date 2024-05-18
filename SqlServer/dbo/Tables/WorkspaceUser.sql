CREATE TABLE [dbo].[WorkspaceUser]
(
	[Id]            INT            IDENTITY (1, 1) NOT NULL,
    [AspNetUsersId] NVARCHAR (450) NOT NULL,
    [WorkspaceId]   INT            NOT NULL,
    [UserInvitationPermission] BIT DEFAULT 0, -- 유저 초대 권한
    [TaskCreationPermission] BIT DEFAULT 0, -- 작업 생성 권한
    FOREIGN KEY ([WorkspaceId]) REFERENCES [dbo].[Workspaces] ([Id]),
    FOREIGN KEY ([AspNetUsersId]) REFERENCES [dbo].AspNetUsers ([Id]),
    CONSTRAINT UC_WorkspaceUser_AspNetUsersId_WorkspaceId UNIQUE (AspNetUsersId, WorkspaceId),
)
