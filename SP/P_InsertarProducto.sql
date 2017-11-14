
DROP PROCEDURE P_InsertarProducto
GO

CREATE PROCEDURE P_InsertarProducto 
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
	INSERT INTO[dbo].[Productos]
		([Codigo],[Tipo],[Sexo],[Estacion],[Talle],[Caracteristica],
		[CantidadInicial],[CantidadEnStock],[PrecioCosto],[PrecioEfectivo],
		[PrecioLista],[Notas], [idCategoria])
	VALUES
	(@Codigo 
	,@Tipo 
	,@Sexo 
	,@Estacion 
	,@Talle 
	,@Caracteristica 
	,@CantidadInicial 
	,@CantidadEnStock 
	,@PrecioCosto 
	,@PrecioEfectivo 
	,@PrecioLista 
	,'SARASA'--@Notas 
	,@idCategoria) 
	GO




