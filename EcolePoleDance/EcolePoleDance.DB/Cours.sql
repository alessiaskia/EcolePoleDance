CREATE TABLE [dbo].[Cours]
(
	[IdCours] INT NOT NULL IDENTITY,
	[NomCours] VARCHAR(32) NOT NULL,
	[MaxParticipants] INT NOT NULL,
	[Description] VARCHAR(MAX) NOT NULL,
	[Image] VARCHAR(512) NOT NULL,
	[Duree] INT NOT NULL,
	[IdProf] INT NOT NULL,

	CONSTRAINT PK_Cours PRIMARY KEY ([IdCours]),
	CONSTRAINT FK_Cours_Prof FOREIGN KEY ([IdProf]) REFERENCES [Prof],
	CONSTRAINT UK_Nom_Cours UNIQUE ([NomCours])

)
