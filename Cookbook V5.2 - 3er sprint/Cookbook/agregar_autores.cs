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
    public partial class agregar_autores : Form
    {
        public agregar_autores()
        {
            InitializeComponent();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_autores_Load(object sender, EventArgs e)
        {
            
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Conexion BD = new Conexion();
            string nom=nombre.Text;
            string apell = apellido.Text;
  
        
            BD.consulta("INSERT INTO autores VALUES (null,'"+nom+"','"+apell+"');");
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
           Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
