using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.Model
{
    public interface ITiendaContext
    {
        IQueryable<Producto> Productos { get; }
        IQueryable<Venta> Ventas { get; }
        IQueryable<ItemVenta> ItemVentas { get; }
        //int SaveChanges();
        //T Add<T>(T entity) where T : class; 
        //T Delete<T>(T entity) where T : class;
        //List<T> GetAll<T>(DbSet<T> dbSet) where T : class;
        //List<T> GetEntity<T>(DbSet<T> dbSet, int id) where T : class;
    }
}
