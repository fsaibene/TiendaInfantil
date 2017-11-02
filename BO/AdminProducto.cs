using System.Linq;
using DacTienda.Model;

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
    }
}
