using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DacTienda.Model
{
    public class ItemVenta : BaseEntity
    {
        [Key]
        public int IdItemVenta { get; set; }
        public int IdVenta { get; set; }
        [ForeignKey("IdVenta")]
        public Venta Venta { get; set; }
        public string CodigoProducto { get; set; }
        [ForeignKey("CodigoProducto")]
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
