CREATE TABLE [dbo].[Client]
(
	[IdClient] INT NOT NULL IDENTITY,
	[Email] VARCHAR(256) NOT NULL,
	[Prenom] VARCHAR(64) NOT NULL,
	[Nom] VARCHAR(64) NOT NULL,
	[Password] VARBINARY(32) NOT NULL,
	[Salt] CHAR(8) NOT NULL,

	CONSTRAINT PK_Client PRIMARY KEY ([IdClient]),
	CONSTRAINT UK_User_Email UNIQUE ([Email]),
	CONSTRAINT CK_User_Email CHECK ([Email] LIKE '___%@___%.__%')
)
