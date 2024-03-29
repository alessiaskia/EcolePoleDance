﻿CREATE TABLE [dbo].[Client_Abonnement]
(
	[IdClient] INT NOT NULL,
	[IdAbonnement] INT NOT NULL,
	[IdEcole] INT NOT NULL,
	[CreditsRestants] INT NOT NULL,
	[DateValidation] DATE NOT NULL DEFAULT GETDATE(),
	[DateEcheance] DATE NOT NULL,
	[Annule] BIT NOT NULL DEFAULT 0,

	CONSTRAINT [PK_ClientAbonnement] PRIMARY KEY CLUSTERED ([IdClient] ASC, [IdAbonnement] ASC, [IdEcole] ASC),
	CONSTRAINT FK_Client_Abonnement_Client FOREIGN KEY ([IdClient]) REFERENCES [Client],
	CONSTRAINT FK_Client_Abonnement_Abonnement FOREIGN KEY ([IdAbonnement]) REFERENCES [Abonnement],
	CONSTRAINT FK_Client_Abonnement_Ecole FOREIGN KEY ([IdEcole]) REFERENCES [Ecole],
	CONSTRAINT CK_Client_Abonnement_DateEcheanche CHECK (DATEDIFF(month, [DateValidation], [DateEcheance]) > 3),
)
