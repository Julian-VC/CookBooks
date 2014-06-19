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
    public partial class pantalla_compra : Form
    {
        public pantalla_compra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_usuario mer = new pantalla_usuario();
            mer.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
