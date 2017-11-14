using DacTienda.Model;
using System;
using System.Windows.Forms;

namespace WindowsTienda
{
    public partial class frmProducto : Form
    {
        private TiendaContext context;
        public frmProducto(TiendaContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (var contextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    Producto nuevoProducto = new Producto();
                    nuevoProducto.Codigo = txtCodigo.Text;
                    nuevoProducto.Tipo = txtTipo.Text;
                    nuevoProducto.CantidadEnStock = int.Parse(txtCantidadStock.Text);
                    nuevoProducto.CantidadInicial = int.Parse(txtCantidadInicial.Text);
                    nuevoProducto.PrecioCosto = int.Parse(txtPrecioCosto.Text);
                    nuevoProducto.PrecioEfectivo = int.Parse(txtPrecioEfectivo.Text);
                    nuevoProducto.Caracteristica = txtCaracteristica.Text;
                    nuevoProducto.Notas = txtNotas.Text;
                    nuevoProducto.Sexo = EnumSexo.NE;
                    nuevoProducto.Estacion = EnumEstacion.Invierno;
                    nuevoProducto.Talle = int.Parse("asdasd");
                    nuevoProducto.idCategoria = 1;
                    context.Productos.Add(nuevoProducto);
                    context.SaveChanges();
                    contextTransaction.Commit();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Se detecto un error");
                    contextTransaction.Rollback();
                }
               
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
