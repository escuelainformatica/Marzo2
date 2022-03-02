using ProyectoWebServiceREST.Models;
using ProyectoWebServiceREST.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoWebServiceREST.api
{
    public class ProductoController : ApiController
    {
        // GET api/<controller>
        public List<Productos> Get()
        {
            var repo = new ProductoRepo();

            return repo.listar() ;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public int Post([FromBody] Productos prod)
        {
            var repo = new ProductoRepo();
            return repo.insertar(prod);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}