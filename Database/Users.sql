-- 유저 테이블

CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL Identity(1, 1) PRIMARY KEY,
	[Created] DateTimeOffset(7) 
		Default(SysDateTimeOffset() AT TIME ZONE 'Korea Standard Time'),
	[Name] NVarChar(255) Not Null,
	[Email] NVarChar(255) Not Null,
	[Password] NVarChar(255) Not Null,

);
