
CREATE PROCEDURE P_ActualizarProducto
			@Codigo nvarchar(6) 
		   ,@Tipo varchar(20)
           ,@Sexo int
           ,@Estacion int
           ,@Talle int
           ,@Caracteristica varchar(30)
           ,@CantidadInicial int
           ,@CantidadEnStock int
           ,@PrecioCosto money
           ,@PrecioEfectivo money
           ,@PrecioLista money
           ,@Notas varchar(200)
           ,@idCategoria int
AS
	UPDATE [dbo].[Productos]
	SET
	 [Codigo] = @Codigo 
	,[Tipo] = @Tipo 
	,[Sexo] = @Sexo 
	,[Estacion] = @Estacion 
	,[Talle] = @Talle 
	,[Caracteristica] = @Caracteristica 
	,[CantidadInicial] = @CantidadInicial 
	,[CantidadEnStock] = @CantidadEnStock 
	,[PrecioCosto] = @PrecioCosto 
	,[PrecioEfectivo] = @PrecioEfectivo 
	,[PrecioLista] = @PrecioLista 
	,[Notas] = @Notas 
	,[idCategoria] = @idCategoria
GO

