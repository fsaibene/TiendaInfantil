using System.Linq;
using DacTienda.Model;
using System.Collections.Generic;

namespace BO
{
    internal static class AdminProducto
    {
        internal static Producto GetProducto(string codigo)
        {
            return (from pro in Admin.db.Productos
                    where pro.Codigo == codigo
                    select pro).SingleOrDefault();
        }

        internal static List<Producto> GetProductsBetween(int init, int end)
        {
            return (
                from prods in Admin.db.Productos
                where prods.CantidadEnStock >= init && prods.CantidadEnStock <= end
                select prods
                ).ToList();
        }
    }
}
