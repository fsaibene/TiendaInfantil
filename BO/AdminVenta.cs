using DacTienda.Model;
using System.Linq;

namespace BO
{
    internal static class AdminVenta
    {
        internal static Venta GetVenta(int id)
        {
            return (from pro in Admin.db.Ventas
                    where pro.IdVenta == id
                    select pro).SingleOrDefault();
        }

    }
}
