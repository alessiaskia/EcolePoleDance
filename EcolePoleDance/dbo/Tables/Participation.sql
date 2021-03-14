CREATE TABLE [dbo].[Participation]
(
	[IdParticipation] INT NOT NULL IDENTITY,
	[IdSession] INT NOT NULL,
	[IdClient] INT NOT NULL,
	[Annule] BIT NOT NULL,

	CONSTRAINT PK_Participation PRIMARY KEY ([IdParticipation]),
	CONSTRAINT FK_Participation_Session FOREIGN KEY ([IdSession]) REFERENCES [Session],
	CONSTRAINT FK_Participation_Client FOREIGN KEY ([IdClient]) REFERENCES [Client],
)
