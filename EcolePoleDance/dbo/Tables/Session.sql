CREATE TABLE [dbo].[Session]
(
	[IdSession] INT NOT NULL IDENTITY,
	[Horaire] DATETIME2 NOT NULL,
	[Duree] TIME NOT NULL,
	[Annule] BIT NOT NULL DEFAULT 0,
	[IdEcole] INT NOT NULL,
	[IdProf] INT NOT NULL,
	[IdCours] INT NOT NULL,

	CONSTRAINT PK_Session PRIMARY KEY ([IdSession]),
	CONSTRAINT FK_Session_Ecole FOREIGN KEY ([IdSession]) REFERENCES [Ecole] ([IdEcole]),
	CONSTRAINT FK_Session_Prof FOREIGN KEY ([IdProf]) REFERENCES [Prof] ([IdProf]),
	CONSTRAINT FK_Session_Cours FOREIGN KEY ([IdCours]) REFERENCES [Cours] ([IdCours])
)
