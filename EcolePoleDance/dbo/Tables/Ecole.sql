CREATE TABLE [dbo].[Ecole]
(
	[IdEcole] INT NOT NULL,
	[Email] NVARCHAR(256) NOT NULL,
	[Tel] NVARCHAR(16) NOT NULL,
	[CompteBancaire] VARCHAR(32) NOT NULL,
	[Rue] NVARCHAR(128) NOT NULL,
	[Numero] NVARCHAR(8) NOT NULL,
	[Ville] NVARCHAR(32) NOT NULL,

	CONSTRAINT PK_Ecole PRIMARY KEY ([IdEcole]),
	CONSTRAINT CK_Ecole_Email CHECK ([Email] LIKE '___%@___%.__%'),
)
