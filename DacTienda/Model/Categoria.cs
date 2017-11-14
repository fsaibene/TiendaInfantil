using System.ComponentModel.DataAnnotations;

namespace DacTienda.Model
{
    public class Categoria : BaseEntity
    {
        [Key]
        public int idCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
