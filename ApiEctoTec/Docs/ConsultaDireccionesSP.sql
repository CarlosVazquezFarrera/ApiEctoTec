USE [EctoTec]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Alberto Vazquez Farrera
-- Create date: <Create Date,,>
-- Description:	Retorna todas as durecciones de la base de datos.
-- =============================================
CREATE PROCEDURE [dbo].[ConsultarDirecciones]
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE 
	@Exito BIT = 0,
	@Mensaje VARCHAR(100) = ''
	SET NOCOUNT ON;

	BEGIN TRY  
			SELECT p.Nombre AS 'Pais', p.Id AS 'IdPais', e.Nombre as 'Entidad', e.Id AS 'IdEntidad', c.Nombre AS 'Ciudad', c.Id AS 'IdCiudad' FROM CIUDAD c
			JOIN ENTIDAD e ON e.Id = c.IdEntidd
			JOIN PAIS P ON P.Id = e.IdPais
	END TRY  
	
	BEGIN CATCH 
		SET @Mensaje = ERROR_MESSAGE();
		SELECT @Mensaje[Mensaje]
	END CATCH
END
