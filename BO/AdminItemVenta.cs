using DacTienda.Model;
using System.Linq;

namespace BO
{
    internal static class AdminItemVenta
    {
        internal static ItemVenta GetItemVenta(int id)
        {
            return (from pro in Admin.db.ItemVentas
                    where pro.IdItemVenta == id
                    select pro).SingleOrDefault();
        }
    }
}
