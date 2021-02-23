CREATE TABLE [dbo].[Inscription]
(
	[IdInscription] INT NOT NULL IDENTITY,
	[Prenom] VARCHAR(50) NOT NULL,
	[Nom] VARCHAR(50) NOT NULL,
	[Email] NVARCHAR(323) NOT NULL,
	[TypeAbonnement] NVARCHAR(50) NOT NULL,
	[DateEnvoi] DATETIME NOT NULL,

	CONSTRAINT PK_Inscription PRIMARY KEY ([IdInscription])
)
