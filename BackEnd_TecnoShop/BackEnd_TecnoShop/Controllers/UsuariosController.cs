using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd_TecnoShop.Models;

namespace BackEnd_TecnoShop.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public IEnumerable<ClsUsuarios> Get()
        {
            //Crear el objeto del gestor
            ClsGestorUsuarios GesUsuarios = new ClsGestorUsuarios();
            //Llamar al metodo del gestor
            return GesUsuarios.GetUsuarios();
        }

        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        public void Post([FromBody] ClsUsuarios usuarios)
        {
            //Crear el objeto del gestor
            ClsGestorUsuarios GesUsuarios = new ClsGestorUsuarios();
            //Llamar al metodo del gestors
            bool res = GesUsuarios.AddUsuarios(usuarios);
        }

        // PUT: api/Usuarios/5
        public bool Put(int id, [FromBody] ClsUsuarios usuarios)
        {
            ClsGestorUsuarios GesUsuarios = new ClsGestorUsuarios();
            bool res = GesUsuarios.UpdateProductos(id, usuarios);

            return res;
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
