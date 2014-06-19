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
    public partial class agregar_usuario : Form
    {
  
        public agregar_usuario()
        {
            InitializeComponent();
        }

        private void agragar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void agragar_usuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion();
            bd.consulta("INSERT INTO usuario VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + 0 + "');");
            bd.cerrarConexion();
            MessageBox.Show("Usuario Creado Correctamente.","Creacion Usuario");
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

        private void e_mail_TextChanged(object sender, EventArgs e)
        {

        }
        private void nomYapell_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipousu_TextChanged(object sender, EventArgs e)
        {
            
        }

   
    }
}
