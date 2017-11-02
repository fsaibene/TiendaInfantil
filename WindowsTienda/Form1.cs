using DacTienda.Model;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsTienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TiendaContext tienda = new TiendaContext())
            {
                Producto newProducto = new Producto { Codigo = "VA100", CantidadEnStock = 10, CantidadInicial = 1, Caracteristica = "Jeans", Estacion = EnumEstacion.Invierno, Notas = "asdasdas", PrecioCosto = 1, PrecioEfectivo = 2, PrecioLista = 3, Sexo = EnumSexo.VA, Talle = 1, Tipo = "cosas" };
                tienda.Productos.Add(newProducto);
                tienda.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto fafafa =  BlTienda.TraerProducto("VA102");
        }
    }
}
