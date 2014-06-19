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
    public partial class autores_eliminar : Form
    {
        string buscado;
        string nombre;
        List<Autor> LISTA=new List<Autor>();
        public autores_eliminar()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombre = comboBox1.Text;
        }
        public void buscar()
        {

            foreach (Autor objeto in LISTA)
            {
                comboBox2.Items.Add(objeto.getId()+":"+objeto.getNombre()+","+objeto.getApellido());
            }
        }

        private void autores_eliminar_Load(object sender, EventArgs e)
        {

        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autor nuevo = new Autor();
            buscado = textBox1.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM autores WHERE apellido LIKE '%" + buscado + "%';");
            for (int i = 0; i < lista.Count; i = i +3)
            {
                string id = lista[i];
                string nombre = lista[i + 1];
                string apellido = lista[i + 2];
                nuevo.setId(int.Parse(id));
                nuevo.setNombre(nombre);
                nuevo.setApellido(apellido);
                LISTA.Add(nuevo);
            }
            this.buscar();
        }

        private void eliminar_btn_Click_1(object sender, EventArgs e)
        {
            string[] splitted = comboBox2.Text.Split(':');
            Conexion bd = new Conexion();
            bd.consulta("DELETE FROM autores where id_autores = '" + splitted[0] + "';;");
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }
    }
}
