using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DacTienda.Model
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public EnumTipoPago TipoPago { get; set; }
        [Required]
        public EnumFormaPago FormaPago { get; set; }
        public int CantidadCuotas { get; set; }
        public decimal PorcentajeInteres { get; set; }
        [Required]
        public decimal Total { get; set; }

        public List<ItemVenta> Items { get; set; }
    }
}
