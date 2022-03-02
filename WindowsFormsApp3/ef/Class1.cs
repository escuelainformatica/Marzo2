using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.ef
{
    class Class1
    {
        public List<Productos> ejemplo()
        {
            // ADO.NET
            List<Productos> resultado = new List<Productos>();

            var conn = new MySqlConnection("server=127.0.0.1;user id=root;password=abc.123;persistsecurityinfo=True;database=base20");
            conn.Open();
            var comando = new MySqlCommand("select Id,Nombre,Precio from Productos",conn);

            var lector = comando.ExecuteReader();
            while(lector.Read())
            {
                Productos prod = new Productos
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector["Nombre"].ToString(),
                    Precio = lector.GetInt32(2)
                };
                resultado.Add(prod);
            }            
            lector.Close();
            conn.Close();
            return resultado;

        }


        public List<Productos> ejemplo2()
        {
            // Entity framework.
            List<Productos> resultado = new List<Productos>();
            // todo: falta implementar (todo = tareas por hacer)
            var con = new Model1();
            //Where(p => p.Nombre == "cocacola"). // LAMBDA
                                                // LINQ
            resultado = con.Productos.                
                ToList();
            //con.Database.SqlQuery("select * from productos");

            return resultado;
        }
    }
}
