namespace DacTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class storeprocedures : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Producto_Insert",
                p => new
                    {
                        Codigo = p.String(maxLength: 6),
                        Tipo = p.String(maxLength: 20, unicode: false),
                        Sexo = p.Int(),
                        Estacion = p.Int(),
                        Talle = p.Int(),
                        idCategoria = p.Int(),
                        Caracteristica = p.String(maxLength: 30, unicode: false),
                        CantidadInicial = p.Int(),
                        CantidadEnStock = p.Int(),
                        PrecioCosto = p.Decimal(precision: 19, scale: 4, storeType: "money"),
                        PrecioEfectivo = p.Decimal(precision: 19, scale: 4, storeType: "money"),
                        PrecioLista = p.Decimal(precision: 19, scale: 4, storeType: "money"),
                        Notas = p.String(maxLength: 200, unicode: false),
                    },
                body:
                    @"INSERT [dbo].[Productos]([Codigo], [Tipo], [Sexo], [Estacion], [Talle], [idCategoria], [Caracteristica], [CantidadInicial], [CantidadEnStock], [PrecioCosto], [PrecioEfectivo], [PrecioLista], [Notas])
                      VALUES (@Codigo, @Tipo, @Sexo, @Estacion, @Talle, @idCategoria, @Caracteristica, @CantidadInicial, @CantidadEnStock, @PrecioCosto, @PrecioEfectivo, @PrecioLista, @Notas)
                      
                      SELECT t0.[RowVersion]
                      FROM [dbo].[Productos] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Codigo] = @Codigo"
            );
            
            CreateStoredProcedure(
                "dbo.Producto_Update",
                p => new
                    {
                        Codigo = p.String(maxLength: 6),
                        Tipo = p.String(maxLength: 20, unicode: false),
                        Sexo = p.Int(),
                        Estacion = p.Int(),
                        Talle = p.Int(),
                        idCategoria = p.Int(),
                        Caracteristica = p.String(maxLength: 30, unicode: false),
                        CantidadInicial = p.Int(),
                        CantidadEnStock = p.Int(),
                        PrecioCosto = p.Decimal(precision: 19, scale: 4, storeType: "money"),
                        PrecioEfectivo = p.Decimal(precision: 19, scale: 4, storeType: "money"),
                        PrecioLista = p.Decimal(precision: 19, scale: 4, storeType: "money"),
                        Notas = p.String(maxLength: 200, unicode: false),
                        RowVersion_Original = p.Binary(maxLength: 8, fixedLength: true, storeType: "rowversion"),
                    },
                body:
                    @"UPDATE [dbo].[Productos]
                      SET [Tipo] = @Tipo, [Sexo] = @Sexo, [Estacion] = @Estacion, [Talle] = @Talle, [idCategoria] = @idCategoria, [Caracteristica] = @Caracteristica, [CantidadInicial] = @CantidadInicial, [CantidadEnStock] = @CantidadEnStock, [PrecioCosto] = @PrecioCosto, [PrecioEfectivo] = @PrecioEfectivo, [PrecioLista] = @PrecioLista, [Notas] = @Notas
                      WHERE (([Codigo] = @Codigo) AND (([RowVersion] = @RowVersion_Original) OR ([RowVersion] IS NULL AND @RowVersion_Original IS NULL)))
                      
                      SELECT t0.[RowVersion]
                      FROM [dbo].[Productos] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Codigo] = @Codigo"
            );
            
            CreateStoredProcedure(
                "dbo.Producto_Delete",
                p => new
                    {
                        Codigo = p.String(maxLength: 6),
                        RowVersion_Original = p.Binary(maxLength: 8, fixedLength: true, storeType: "rowversion"),
                    },
                body:
                    @"DELETE [dbo].[Productos]
                      WHERE (([Codigo] = @Codigo) AND (([RowVersion] = @RowVersion_Original) OR ([RowVersion] IS NULL AND @RowVersion_Original IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Producto_Delete");
            DropStoredProcedure("dbo.Producto_Update");
            DropStoredProcedure("dbo.Producto_Insert");
        }
    }
}
