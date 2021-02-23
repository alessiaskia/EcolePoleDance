CREATE TABLE [dbo].[Abonnement]
(
	[IdAbonnement] INT NOT NULL IDENTITY,
	[NombreCredits] INT NOT NULL,
	[Montant] DECIMAL(19, 2) NOT NULL,
	[PrixParCours] DECIMAL(19, 2) NOT NULL,

	CONSTRAINT PK_Abonnement PRIMARY KEY ([IdAbonnement]),
	CONSTRAINT CK_Abonnement_Montant CHECK ([Montant] >= 0),
	CONSTRAINT CK_Abonnement_PrixParCours CHECK ([Montant] >= 0),
)
