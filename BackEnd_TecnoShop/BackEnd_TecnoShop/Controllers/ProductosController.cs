using BackEnd_TecnoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEnd_TecnoShop.Controllers
{
    public class ProductosController : ApiController
    {
        // GET: api/Productos
        [HttpGet]
        [Route("api/Productos")]
        public IEnumerable<ClsProductos> Get()
        {
            ClsGestorProductos GesProductos = new ClsGestorProductos();
            return GesProductos.GetProductos("", "", "");
        }

        // GET: api/Productos/Filtro?
        [HttpGet]
        [Route("api/Productos/Filtro")]
        public IEnumerable<ClsProductos> GetFiltro(string Categoria = "", string Marca = "", string Nombre = "")
        {
            ClsGestorProductos GesProductos = new ClsGestorProductos();
            return GesProductos.GetProductos(Categoria, Marca, Nombre);
        }

        // POST: api/Productos
        public bool Post([FromBody] ClsProductos productos)
        {
            ClsGestorProductos GesProductos = new ClsGestorProductos();
            bool res = GesProductos.AddProductos(productos);
            
            return res;
        }

        // PUT: api/Productos/5
        public bool Put(int id, [FromBody] ClsProductos productos)
        {
            ClsGestorProductos GesProductos = new ClsGestorProductos();
            bool res = GesProductos.UpdateProductos(id, productos);

            return res;
        }

        // DELETE: api/Productos/5
        public bool Delete(int id)
        {
            ClsGestorProductos GesProductos = new ClsGestorProductos();
            bool res = GesProductos.DeleteProductos(id);

            return res;
        }
    }
}
