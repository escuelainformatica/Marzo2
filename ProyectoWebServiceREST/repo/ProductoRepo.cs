using ProyectoWebServiceREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebServiceREST.repo
{
    public class ProductoRepo
    {
        public List<Productos> listar()
        {
            var resultado = new List<Productos>();
            // entity framework
            var cliente = new ConexionEF();
            resultado = cliente.Productos.ToList();

            return resultado;
        }
        public int insertar(Productos prod)
        {
            var resultado = 0;
            var cliente = new ConexionEF();
            cliente.Productos.Add(prod); // insert into ...
            cliente.SaveChanges();

            return resultado;
        }
    }
}