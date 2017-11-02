using BO;
using DacTienda.Model;
using System.Collections.Generic;

namespace Negocio
{
    public static class BlTienda
    {
        public static void AgregarProducto(Producto producto)
        {
            Admin.Add(producto);
            Admin.SaveChanges();
        }

        public static void EliminarProducto(Producto producto)
        {
            Admin.Delete(producto);
            Admin.SaveChanges();
        }

        public static List<Producto> TraerTodosProductos()
        {
           return Admin.GetAll(Admin.db.Productos);
        }

        public static Producto TraerProducto(string codigo)
        {
            return Admin.GetEntity<Producto, string>(codigo);
        }

        public static Venta TraerVenta(int id)
        {
            return Admin.GetEntity<Venta, int>(id);
        }

        public static ItemVenta TraerItemVenta(int id)
        {
            return Admin.GetEntity<ItemVenta, int>(id);
        }
    }
}
