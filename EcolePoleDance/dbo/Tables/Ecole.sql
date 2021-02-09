CREATE TABLE [dbo].[Ecole]
(
	[IdEcole] INT NOT NULL,
	[Email] VARCHAR(256) NOT NULL,
	[Tel] VARCHAR(16) NOT NULL,
	[CompteBancaire] VARCHAR(32) NOT NULL,
	[Rue] VARCHAR(128) NOT NULL,
	[Numero] VARCHAR(8) NOT NULL,
	[Ville] VARCHAR(32) NOT NULL,

	CONSTRAINT PK_Ecole PRIMARY KEY ([IdEcole]),
	CONSTRAINT CK_Ecole_Email CHECK ([Email] LIKE '___%@___%.__%'),
)
