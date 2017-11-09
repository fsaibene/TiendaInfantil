using BO;
using DacTienda.Model;
using System.Collections.Generic;
using System.Linq;

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

        public static List<Producto> TraerProductos()
        {
            return Admin.GetAll(Admin.db.Productos);
        }

        public static Producto TraerProducto(string codigo)
        {
            return Admin.GetEntity<Producto, string>(codigo);
        }

        public static void AgregarVenta(Venta venta)
        {
            Admin.Add(venta);
            Admin.SaveChanges();
        }

        public static void EliminarVenta(Venta venta)
        {
            Admin.Delete(venta);
            Admin.SaveChanges();
        }

        public static List<Venta> TraerVentas()
        {
            return Admin.GetAll(Admin.db.Ventas);
        }

        public static Venta TraerVenta(int id)
        {
            return Admin.GetEntity<Venta, int>(id);
        }

        public static ItemVenta TraerItemVenta(int id)
        {
            return Admin.GetEntity<ItemVenta, int>(id);
        }

        public static void AgregarItemVenta(ItemVenta itemVenta)
        {
            Admin.Add(itemVenta);
            Admin.SaveChanges();
        }

        public static void EliminarItemVenta(ItemVenta itemVenta)
        {
            Admin.Delete(itemVenta);
            Admin.SaveChanges();
        }

        public static List<ItemVenta> TraerItemVentas()
        {
            return Admin.GetAll(Admin.db.ItemVentas);
        }

        public static List<Producto> TraerRangoDeProductosPorStock(int init, int end)
        {
            return Admin.GetProductsBetween(init, end);
        }

        public static void Modificar(Producto producto)
        {
            Admin.Modificar(producto);
            Admin.SaveChanges();
        }
    }
}
