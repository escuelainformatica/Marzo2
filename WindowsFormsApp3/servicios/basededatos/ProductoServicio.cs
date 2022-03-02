using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.ef;

namespace WindowsFormsApp3.servicios.basededatos
{
    class ProductoServicio
    {
        public List<Productos> listar()
        {
            List<Productos> resultado = new List<Productos>();
            var cliente = new Model1();
            resultado = cliente.Productos.ToList();

            return resultado;
        }
    }
}
