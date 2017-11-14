using DacTienda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace BO
{
    public static class Admin
    {
        public static TiendaContext db = new TiendaContext();

        public static T Add<T>(T entity) where T : class
        {
            return db.Set<T>().Add(entity);
        }

        public static void Update<T>(T entity) where T : class
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            db.Entry(entity);
        }

        public static T Delete<T>(T entity) where T : class
        {
            return db.Set<T>().Remove(entity);
        }

        public static List<T> GetAll<T>(DbSet<T> dbSet) where T : class
        {
            List<T> lista = (from liCli in dbSet
                             select liCli).ToList();
            return lista;
        }

        //public static T GetEntity<T>(DbSet<T> dbSet) where T : class
        //{
        //    return dbSet.First();
        //}

        public static T GetEntity<T, U>(U id) where T : class
        {
            dynamic varReturn = null;
            if (typeof(T) == typeof(Producto))
            {
                varReturn = AdminProducto.GetProducto(id as string);
            }

            else if (typeof(T) == typeof(Venta))
            {
                varReturn = AdminVenta.GetVenta(int.Parse(id as string));
            }

            else if (typeof(T) == typeof(ItemVenta))
            {
                varReturn = AdminItemVenta.GetItemVenta(int.Parse(id as string));
            }

            return varReturn;
        }

        public static List<Producto> GetProductsBetween(int init, int end)
        {
            return AdminProducto.GetProductsBetween(init, end);
        }
            
        public static void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
