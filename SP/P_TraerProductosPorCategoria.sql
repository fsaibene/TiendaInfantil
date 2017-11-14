DROP PROCEDURE P_TraerProductosPorCategoria
GO

CREATE PROCEDURE P_TraerProductosPorCategoria
			@idCategoria int 
AS
	SELECT * FROM [dbo].[Productos]
	WHERE [IdCategoria] = @idCategoria
GO
