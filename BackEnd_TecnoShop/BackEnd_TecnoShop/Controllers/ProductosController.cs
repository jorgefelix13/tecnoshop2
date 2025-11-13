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
        public IEnumerable<ClsProductos> Get()
        {
            ClsGestorProductos GesProductos = new ClsGestorProductos();
            return GesProductos.GetProductos();
        }

        // GET: api/Productos/5
        public string Get(int id)
        {
            return "value";
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
