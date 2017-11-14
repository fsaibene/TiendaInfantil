namespace DacTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spu : DbMigration
    {
        public override void Up()
        {
            RenameStoredProcedure(name: "dbo.Producto_Insert", newName: "P_InsertarProducto");
            RenameStoredProcedure(name: "dbo.P_ActualizarProducto", newName: "Producto_Update");
        }
        
        public override void Down()
        {
            RenameStoredProcedure(name: "dbo.Producto_Update", newName: "P_ActualizarProducto");
            RenameStoredProcedure(name: "dbo.P_InsertarProducto", newName: "Producto_Insert");
        }
    }
}
