CREATE TABLE [dbo].[Client]
(
	[IdClient] INT NOT NULL IDENTITY,
	[Email] NVARCHAR(256) NOT NULL,
	[Prenom] NVARCHAR(64) NOT NULL,
	[Nom] NVARCHAR(64) NOT NULL,
	[Password] NVARCHAR(32) NOT NULL,
	[Salt] CHAR(8) NOT NULL,

	CONSTRAINT PK_Client PRIMARY KEY ([IdClient]),
	CONSTRAINT UK_User_Email UNIQUE ([Email]),
	CONSTRAINT CK_User_Email CHECK ([Email] LIKE '___%@___%.__%')
)
