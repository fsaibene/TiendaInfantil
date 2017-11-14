namespace DacTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiomaquina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            AddColumn("dbo.Productos", "idCategoria", c => c.Int(nullable: false));
            CreateIndex("dbo.Productos", "idCategoria");
            AddForeignKey("dbo.Productos", "idCategoria", "dbo.Categorias", "idCategoria", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "idCategoria", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "idCategoria" });
            DropColumn("dbo.Productos", "idCategoria");
            DropTable("dbo.Categorias");
        }
    }
}
