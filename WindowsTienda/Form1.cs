using DacTienda.Model;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace WindowsTienda
{
    public partial class Form1 : Form
    {
        public Producto Prod1;
        public TiendaContext tienda;
        public Form1()
        {
            InitializeComponent();
            tienda = new TiendaContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Categoria newCategoria = new Categoria { Nombre = "Sarasa" };
            //tienda.Categorias.Add(newCategoria);
            //tienda.SaveChanges();
            //Producto newProducto = new Producto { Codigo = "VA155", CantidadEnStock = 10, CantidadInicial = 1, Caracteristica = "Jeans", Estacion = EnumEstacion.Invierno, Notas = "asdasdas", PrecioCosto = 1, PrecioEfectivo = 2, PrecioLista = 3, Sexo = EnumSexo.VA, Talle = 1, Tipo = "cosas", idCategoria = 1 };
            //tienda.Productos.Add(newProducto);
            //tienda.SaveChanges();

            Producto newProducto = new Producto { Codigo = "VA666", CantidadEnStock = 6, CantidadInicial = 1, Caracteristica = "Campera Cuero", Estacion = EnumEstacion.Invierno, Notas = "asdasdas", PrecioCosto = 1, PrecioEfectivo = 2, PrecioLista = 3, Sexo = EnumSexo.VA, Talle = 1, Tipo = "cosas", idCategoria = 1 };
            BlTienda.AgregarProducto(newProducto);            
            //tienda.Productos.Add(newProducto);
            //tienda.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Producto newProducto = new Producto { Codigo = "VA100", CantidadEnStock = 10, CantidadInicial = 1, Caracteristica = "Jeans", Estacion = EnumEstacion.Invierno, Notas = "asdasdas", PrecioCosto = 1, PrecioEfectivo = 2, PrecioLista = 3, Sexo = EnumSexo.VA, Talle = 1, Tipo = "cosas" };
            Venta venta1 = new Venta
            {
                CantidadCuotas = 1,
                Fecha = DateTime.Now,
                FormaPago = EnumFormaPago.Efectivo,
                Items = new List<ItemVenta>(),
                PorcentajeInteres = 10,
                TipoPago = EnumTipoPago.Efectivo,
                Total = 222
            };

            BlTienda.AgregarVenta(venta1);
            ItemVenta iv = new ItemVenta { Cantidad = 1, CodigoProducto = newProducto.Codigo, IdVenta = venta1.IdVenta };
            BlTienda.AgregarItemVenta(iv);
            */
            List<Producto> listaStockProductos =  BlTienda.TraerRangoDeProductosPorStock(0, 9);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = BlTienda.TraerProductos();
            //dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnTraer1_Click(object sender, EventArgs e)
        {
            Prod1 = BlTienda.TraerProducto("VA100");
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            try
            {
                Prod1.CantidadEnStock = new Random().Next(0, 99999999);
                BlTienda.Modificar(Prod1);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Se rompió atr" + ex.ToString());
            }
            catch (Exception eze)
            {
                MessageBox.Show("Se rompió atr" + eze.ToString());
            }
        }
    }
}
