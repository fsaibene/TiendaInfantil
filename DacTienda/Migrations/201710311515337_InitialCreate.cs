namespace DacTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemVentas",
                c => new
                    {
                        IdItemVenta = c.Int(nullable: false, identity: true),
                        IdVenta = c.Int(nullable: false),
                        CodigoProducto = c.String(maxLength: 6),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdItemVenta)
                .ForeignKey("dbo.Productos", t => t.CodigoProducto)
                .ForeignKey("dbo.Ventas", t => t.IdVenta, cascadeDelete: true)
                .Index(t => t.IdVenta)
                .Index(t => t.CodigoProducto);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 6),
                        Tipo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Sexo = c.Int(nullable: false),
                        Estacion = c.Int(nullable: false),
                        Talle = c.Int(nullable: false),
                        Caracteristica = c.String(nullable: false, maxLength: 30, unicode: false),
                        CantidadInicial = c.Int(nullable: false),
                        CantidadEnStock = c.Int(nullable: false),
                        PrecioCosto = c.Decimal(nullable: false, storeType: "money"),
                        PrecioEfectivo = c.Decimal(nullable: false, storeType: "money"),
                        PrecioLista = c.Decimal(nullable: false, storeType: "money"),
                        Notas = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        IdVenta = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        TipoPago = c.Int(nullable: false),
                        FormaPago = c.Int(nullable: false),
                        CantidadCuotas = c.Int(nullable: false),
                        PorcentajeInteres = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdVenta);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVentas", "IdVenta", "dbo.Ventas");
            DropForeignKey("dbo.ItemVentas", "CodigoProducto", "dbo.Productos");
            DropIndex("dbo.ItemVentas", new[] { "CodigoProducto" });
            DropIndex("dbo.ItemVentas", new[] { "IdVenta" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Productos");
            DropTable("dbo.ItemVentas");
        }
    }
}
