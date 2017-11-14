using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace DacTienda.Model
{
    public class TiendaContext: DbContext, ITiendaContext
    {

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ItemVenta> ItemVentas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        private List<DbSet> DbSets { get; set; }

        public TiendaContext() : base("KeyTiendaDB")
        {

        }

        IQueryable<Producto> ITiendaContext.Productos
        {
            get { return Productos; }
        }

        //public DbSet<Producto> Productos { get; set; }

        IQueryable<Venta> ITiendaContext.Ventas
        {
            get { return Ventas; }
        }

        IQueryable<ItemVenta> ITiendaContext.ItemVentas
        {
            get { return ItemVentas; }
        }

        public DbSet GetDbSetByType(Type type)
        {
            return DbSets.First(db => (db.GetType().GetGenericArguments()[0] as Type) == type);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .MapToStoredProcedures(p => p
                    .Insert(sp => sp.HasName("P_InsertarProducto")
                                    .Parameter(pm => pm.Codigo         , "Codigo")
                                    .Parameter(pm => pm.Tipo           , "Tipo")
                                    .Parameter(pm => pm.Sexo           , "Sexo")
                                    .Parameter(pm => pm.Estacion       , "Estacion")
                                    .Parameter(pm => pm.Talle          , "Talle")
                                    .Parameter(pm => pm.Caracteristica , "Caracteristica")
                                    .Parameter(pm => pm.CantidadInicial, "CantidadInicial")
                                    .Parameter(pm => pm.CantidadEnStock, "CantidadEnStock")
                                    .Parameter(pm => pm.PrecioCosto    , "PrecioCosto")
                                    .Parameter(pm => pm.PrecioEfectivo , "PrecioEfectivo")
                                    .Parameter(pm => pm.PrecioLista    , "PrecioLista")
                                    .Parameter(pm => pm.Notas          , "Notas")
                                    .Parameter(pm => pm.idCategoria    , "idCategoria")));
        }

    }
}
