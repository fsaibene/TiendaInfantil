DROP PROCEDURE P_TraerProductosPorCodigo
GO

CREATE PROCEDURE P_TraerProductosPorCodigo
			@Codigo nvarchar(6) 
AS
	SELECT * FROM [dbo].[Productos]
	WHERE [Codigo] = @Codigo 
GO

