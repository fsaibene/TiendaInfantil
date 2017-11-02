using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.Model
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        [MaxLength(6)]
        public string Codigo { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string Tipo { get; set; }

        [Required]
        public EnumSexo Sexo { get; set; }

        [Required]
        public EnumEstacion Estacion { get; set; }

        [Required]
        public int Talle { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string Caracteristica { get; set; }

        public int CantidadInicial { get; set; }

        public int CantidadEnStock { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal PrecioCosto { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal PrecioEfectivo { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal PrecioLista { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(200)]
        public string Notas { get; set; }
    }
}
