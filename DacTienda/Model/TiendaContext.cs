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

        //public T Add<T>(T entity) where T : class
        //{
        //    return Set<T>().Add(entity);
        //}

        //public T Delete<T>(T entity) where T : class
        //{
        //    return Set<T>().Remove(entity);
        //}

        //public List<T> GetAll<T>(DbSet<T> dbSet) where T : class
        //{
        //    List<T> lista = (from liCli in dbSet
        //                     select liCli).ToList();
        //    return lista;
        //}
    }
}
