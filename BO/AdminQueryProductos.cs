using DacTienda.Model;
using System.Collections.Generic;
using System.Linq;

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
            return Admin.db.Productos.SqlQuery("SELECT * FROM [dbo].[Productos]").ToList(); 
        }

        public List<Producto> TraerTodos(Categoria categoria)
        {
           return Admin.db.Productos.SqlQuery("SELECT * FROM [dbo].[Productos] WHERE IdCategoria = {0}", categoria.idCategoria.ToString()).ToList();
        }

        public List<Producto> TraerTodos(string id)
        {
            return Admin.db.Productos.SqlQuery("SELECT * FROM [dbo].[Productos] WHERE Codigo = {0}", id).ToList();
        }

        #endregion

        #region SP

        public void AgregarQuerySpu(Producto producto)
        {
            Admin.db.Database.ExecuteSqlCommand("P_InsertarProducto "+
                "@Codigo = {0}, @Tipo = {1}, @Sexo = {2}, @Estacion = {3}, "+
                "@Talle = {4}, @Caracteristica = {5}, @CantidadInicial = {6}, "+
                "@CantidadEnStock = {7}, @PrecioCosto = {8}, @PrecioEfectivo = {9}, "+
                "@PrecioLista = {10}, @Notas = {11}, @idCategoria = {12} "
                ,producto.Codigo
                ,producto.Tipo 
                ,producto.Sexo 
                ,producto.Estacion 
                ,producto.Talle 
                ,producto.Caracteristica
                ,producto.CantidadInicial
                ,producto.CantidadEnStock
                ,producto.PrecioCosto 
                ,producto.PrecioEfectivo
                ,producto.PrecioLista 
                ,producto.Notas 
                ,producto.idCategoria
                );
        }

        public void ModificarQuerySpu(Producto producto)
        {
            Admin.db.Database.ExecuteSqlCommand("P_ActualizarProducto " +
                "@Codigo = {0}, @Tipo = {1}, @Sexo = {2}, @Estacion = {3}, " +
                "@Talle = {4}, @Caracteristica = {5}, @CantidadInicial = {6}, " +
                "@CantidadEnStock = {7}, @PrecioCosto = {8}, @PrecioEfectivo = {9}, " +
                "@PrecioLista = {10}, @Notas = {11}, @idCategoria = {12} "
                , producto.Codigo
                , producto.Tipo
                , producto.Sexo
                , producto.Estacion
                , producto.Talle
                , producto.Caracteristica
                , producto.CantidadInicial
                , producto.CantidadEnStock
                , producto.PrecioCosto
                , producto.PrecioEfectivo
                , producto.PrecioLista
                , producto.Notas
                , producto.idCategoria
                );
        }

        public void EliminarQuerySpu(string id)
        {
            Admin.db.Database.ExecuteSqlCommand("P_EliminarProducto @Codigo = {0}", id);
        }

        public List<Producto> TraerTodosSpu()
        {
            return Admin.db.Productos.SqlQuery("P_TraerProductos", null).ToList();
        }

        public List<Producto> TraerTodosSpu(Categoria categoria)
        {
            return Admin.db.Productos.SqlQuery("P_TraerProductoPorCategoria @idCategoria = {0}", categoria.idCategoria.ToString()).ToList();
        }

        public List<Producto> TraerTodosSpu(string id)
        {
            return Admin.db.Productos.SqlQuery("P_TraerProductoPorCodigo @Codigo = {0}", id).ToList();
        }

        #endregion
    }
}
