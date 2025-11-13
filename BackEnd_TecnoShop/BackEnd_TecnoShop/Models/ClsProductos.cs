using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_TecnoShop.Models
{
    public class ClsProductos
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Especificaciones { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }
        public string Marca { get; set; }

        public ClsProductos()
        {

        }
        public ClsProductos(int id, string nombre, string descripcion, string especificaciones,
            decimal precioVenta, decimal precioCompra, int stock, string categoria,
            bool activo, string marca)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Especificaciones = especificaciones;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            Stock = stock;
            Categoria = categoria;
            Activo = activo;
            Marca = marca;
        }
    }
}