using DacTienda.Model;
using System.Collections.Generic;

namespace BO
{
    public class AdminQueryProductos
    {
        #region query

        public void AgregarQuery(Producto producto)
        {
            Admin.db.Database.ExecuteSqlCommand(
                "INSERT INTO[dbo].[Productos]" +
                    "([Codigo],[Tipo],[Sexo],[Estacion],[Talle],[Caracteristica]," +
                    "[CantidadInicial],[CantidadEnStock],[PrecioCosto],[PrecioEfectivo]," +
                    "[PrecioLista],[Notas], [idCategoria])" +
                "VALUES" +
               "(" + producto.Codigo +
               "," + producto.Tipo +
               "," + producto.Sexo +
               "," + producto.Estacion +
               "," + producto.Talle +
               "," + producto.Caracteristica +
               "," + producto.CantidadInicial +
               "," + producto.CantidadEnStock +
               "," + producto.PrecioCosto +
               "," + producto.PrecioEfectivo +
               "," + producto.PrecioLista +
               "," + producto.Notas +
               "," + producto.idCategoria + ")" +
               "GO"
            );
        }

        public void ModificarQuery(Producto producto)
        {
            Admin.db.Database.ExecuteSqlCommand(
                "UPDATE [dbo].[Productos]" +
                "SET" +
                "[Codigo] = " + producto.Codigo + "," +
                "[Tipo] = " + producto.Tipo + "," +
                "[Sexo] = " + producto.Sexo + "," +
                "[Estacion] = " + producto.Estacion + "," +
                "[Caracteristica] = " + producto.Caracteristica + "," +
                "[CantidadInicial] = " + producto.CantidadInicial + "," +
                "[CantidadEnStock] = " + producto.CantidadEnStock + "," +
                "[PrecioCosto] = " + producto.PrecioCosto + "," +
                "[PrecioEfectivo] = " + producto.PrecioEfectivo + "," +
                "[PrecioLista] = " + producto.PrecioLista + "," +
                "[Notas] = " + producto.Notas + "," +
                "[idCategoria] = " + producto.idCategoria + "," +
                " WHERE Codigo = " + producto.Codigo +
                "GO"
            );
        }

        public void EliminarQuery(string id)
        {
            Admin.db.Database.ExecuteSqlCommand(
                "DELETE FROM [dbo].[Productos]" +
                " WHERE Codigo = " + id +
                "GO"
            );

        }

        public List<Producto> TraerTodos()
        {

            return null;
        }

        public List<Producto> TraerTodos(Categoria categoria)
        {
            return null;
        }

        public List<Producto> TraerTodos(string id)
        {
            return null;
        }

        #endregion

        #region SP

        public void AgregarQuerySpu(Producto producto)
        {

        }

        public void ModificarQuerySpu(Producto producto)
        {

        }

        public void EliminarQuerySpu(string id)
        {

        }

        public List<Producto> TraerTodosSpu()
        {
            return null;
        }

        public List<Producto> TraerTodosSpu(Categoria categoria)
        {
            return null;
        }

        public List<Producto> TraerTodosSpu(string id)
        {
            return null;
        }

        #endregion
    }
}
