using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.ef;
using WindowsFormsApp3.servicios.basededatos;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ps = new ProductoServicio();
            List<Productos> resultado = ps.listar();

            dataGridView1.DataSource = resultado;
        }
    }
}
