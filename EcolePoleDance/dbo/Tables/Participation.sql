CREATE TABLE [dbo].[Participation]
(
	[IdSession] INT NOT NULL,
	[IdClient] INT NOT NULL,
	[Annule] BIT NOT NULL DEFAULT 0,

	CONSTRAINT [PK_Participation] PRIMARY KEY CLUSTERED ([IdSession] ASC, [IdClient] ASC),
	CONSTRAINT FK_Participation_Session FOREIGN KEY ([IdSession]) REFERENCES [Session],
	CONSTRAINT FK_Participation_Client FOREIGN KEY ([IdClient]) REFERENCES [Client],
)
