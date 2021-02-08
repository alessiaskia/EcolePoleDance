CREATE TABLE [dbo].[Participation]
(
	[IdSession] INT NOT NULL,
	[IdClient] INT NOT NULL,
	[Annule] BIT NOT NULL,

	CONSTRAINT FK_Participation_Session FOREIGN KEY ([IdSession]) REFERENCES [Session],
	CONSTRAINT FK_Participation_Client FOREIGN KEY ([IdClient]) REFERENCES [Client],
)
