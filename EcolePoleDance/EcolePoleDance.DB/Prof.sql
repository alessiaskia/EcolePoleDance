﻿CREATE TABLE [dbo].[Prof]
(
	[IdProf] INT NOT NULL IDENTITY,
	[Prenom] VARCHAR(64) NOT NULL,
	[InfoProf] VARCHAR(MAX) NOT NULL,

	CONSTRAINT PK_Prof PRIMARY KEY ([IdProf])
)
