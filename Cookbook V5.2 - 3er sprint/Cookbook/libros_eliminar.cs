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
    public partial class libros_eliminar : Form
   {
        string buscado;
        string idLibroAEliminar;
        List<libros> LISTA=new List<libros>();
        public libros_eliminar()
        {
            InitializeComponent();
        }

           
        class libros
        {
            string id;
            string nombre;
            public libros()
            {

            }
            public void agregar(string id, string nombre)
            {
                this.id = id;
                this.nombre = nombre;
            }
            public string getNombre()
            {
                return this.nombre;
            }
            public string getId()
            {
                return this.id;
            }

        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {

        }

        public void buscar()
        {

            foreach (libros objeto in LISTA)
            {
                comboBox2.Items.Add(objeto.getId() +" "+objeto.getNombre());
            }
        }

        private void autores_eliminar_Load(object sender, EventArgs e)
        {

        }


        private void libros_eliminar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            libros nuevo = new libros();
            buscado = textBox2.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM libros WHERE titulo LIKE '%" + buscado + "%';");
            for (int i = 0; i < lista.Count; i = i + 10)
            {
                string id = lista[i];
                string nombre = lista[i + 1];
                nuevo.agregar(id, nombre);
                LISTA.Add(nuevo);
            }
            this.buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion();
            bd.consulta("DELETE FROM libros where id_libro = '" + idLibroAEliminar + "';");
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] splitted = comboBox2.Text.Split(' ');
            idLibroAEliminar = splitted[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
