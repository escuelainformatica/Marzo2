using ProyectoWebService.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebService.repo
{
    public class ProductoRepo
    {
        public List<Productos> listar()
        {
            var resultado = new List<Productos>();
            // entity framework
            var cliente = new Base20();
            resultado = cliente.Productos.ToList();

            return resultado;
        }
    }
}