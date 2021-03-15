-- =============================================
-- Author:		<Alessia Scaccia>
-- Create date: <15-03-2021>
-- Description:	<Procedure stockée pour l'insertion d'une instance d'abonnement choisi par l'utilisateur>
-- =============================================
CREATE PROCEDURE [dbo].[InsertInstanceAbonnement] 
	-- Add the parameters for the stored procedure here
	@idClient int,
	@idAbonnement int,
	@idEcole int,
	@creditsRestants int,
	@dateValidation date,
	@dateEcheanche date,
	@annule bit
AS
BEGIN
    -- Insert statements for procedure here
	INSERT INTO Client_Abonnement VALUES(@idClient, @idAbonnement, @idEcole, @creditsRestants, @dateValidation, @dateEcheanche, @annule)
END