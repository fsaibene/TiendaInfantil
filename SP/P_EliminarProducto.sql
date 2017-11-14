
CREATE PROCEDURE P_EliminarProducto
			@Codigo nvarchar(6) 
AS
	DELETE FROM [dbo].[Productos]
	WHERE [Codigo] = @Codigo 
GO

