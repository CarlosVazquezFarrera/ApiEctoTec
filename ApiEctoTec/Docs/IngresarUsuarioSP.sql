USE [EctoTec]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos Alberto Vazquez Farrera
-- Create date: <Create Date,,>
-- Description:	Realiza el registro de un usuario en la base de datos, no sin antes hacer ciertas validaciones
-- =============================================
CREATE PROCEDURE [dbo].[IngresarUsuario]
	@Nombre VARCHAR(MAX) = NULL,
	@Mail VARCHAR(MAX) = NULL,
	@Telefono VARCHAR(MAX) = NULL,
	@FechaNacimiento VARCHAR(20) = NULL,
	@CiudadNacimiento INT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE 
	@InsertarUsuario VARCHAR(20) = 'InsertarUsuario',
	@Exito BIT = 0,
	@Mensaje VARCHAR(100) = ''

	IF (@Nombre IS NULL OR @Mail IS NULL OR @Telefono IS NULL OR @FechaNacimiento IS NULL OR @CiudadNacimiento IS NULL)
		BEGIN
			SET @Mensaje = 'Debe llenar todos los datos';	
		END
	ELSE
		BEGIN
			IF ((SELECT COUNT(*) FROM USUARIO WHERE Mail = @Mail)>0)
				BEGIN
					SET @Mensaje = 'El Correo ya se encuentra en uso';
				END
			ELSE
				BEGIN
					BEGIN TRAN @InsertarUsuario;
					BEGIN TRY  
						INSERT INTO USUARIO (Nombre, Mail, Telefono, Fecha, IdCiudad) VALUES (@Nombre, @Mail, @Telefono, @FechaNacimiento, @CiudadNacimiento);
						SET @Mensaje = 'Se registró el usuario de forma correcta';
						SET @Exito = 1;
						COMMIT TRAN @InsertarUsuario
					END TRY  
			
					BEGIN CATCH 
						SET @Mensaje = ERROR_MESSAGE();
						ROLLBACK TRANSACTION @InsertarUsuario;;
					END CATCH
				END
		END
		SELECT @Exito[Exito], @Mensaje[Mensaje]
	END

