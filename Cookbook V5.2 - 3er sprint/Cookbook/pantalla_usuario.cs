using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook
{
    public partial class pantalla_usuario : Form
    {
        string buscado;
       // List<libros> LISTA = new List<libros>();

        public pantalla_usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificar_usuario mer = new modificar_usuario();
            mer.ShowDialog();
        }

        private void listBox1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //libros nuevo = new libros();
            buscado = textBox1.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM libros WHERE titulo LIKE'%" + buscado + "%';");
        }
    }
}
