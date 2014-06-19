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
    public partial class eliminar_usuario : Form
    {
        string buscado;
        string email;
        List<usuario> LISTA = new List<usuario>();

        public eliminar_usuario()
        {
            InitializeComponent();
        }

        class usuario
        {
            string email;
            string nombreYapellido;
           
           
            public void agregar(string email, string nombreYapellido)
            {
                this.email = email;
                this.nombreYapellido = nombreYapellido;
            }
            public string getNombreYapellido()
            {
                return this.nombreYapellido;
            }
            public string getEmail()
            {
                return this.email;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario nuevo = new usuario();
            buscado = textBox1.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM usuario WHERE nomYape LIKE'%" + buscado + "%';");
            for (int i = 0; i < lista.Count; i = i + 10)
            {
                string email = lista[i];
                string nombreYapellido = lista[i + 1];
                nuevo.agregar(email, nombreYapellido);
                LISTA.Add(nuevo);
            }
            this.buscar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            email = comboBox1.Text;
        }
        public void buscar()
        {

            foreach (usuario objeto in LISTA)
            {
                comboBox1.Items.Add(objeto.getEmail());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion();
            bd.consulta("DELETE FROM usuario WHERE email = '" + email + "';");
            MessageBox.Show("Usuario eliminado correctamente.","Eliminar Usuario");
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void eliminar_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
