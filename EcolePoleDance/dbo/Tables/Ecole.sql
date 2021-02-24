CREATE TABLE [dbo].[Ecole] (
    [IdEcole]        INT            IDENTITY (1, 1) NOT NULL,
    [Email]          NVARCHAR (256) NOT NULL,
    [Tel]            NVARCHAR (16)  NOT NULL,
    [CompteBancaire] VARCHAR (32)   NOT NULL,
    [Rue]            NVARCHAR (128) NOT NULL,
    [Numero]         NVARCHAR (8)   NOT NULL,
    [Ville]          NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK_Ecole] PRIMARY KEY CLUSTERED ([IdEcole] ASC),
    CONSTRAINT [CK_Ecole_Email] CHECK ([Email] like '___%@___%.__%')
);


