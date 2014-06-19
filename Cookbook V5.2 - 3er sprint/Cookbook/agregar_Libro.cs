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
    public partial class agregar_Libro : Form
    {
        List<Autor> LISTA = new List<Autor>();
        Autor autor;
        public agregar_Libro()
        {
            InitializeComponent();
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM autores;");
            for (int i = 0; i < lista.Count; i = i + 3)
            {
                Autor autor = new Autor();
                autor.setId(int.Parse(lista[i]));
                autor.setNombre(lista[i + 1]);

                autor.setApellido(lista[i + 2]);
                LISTA.Add(autor);
            }
            foreach (Autor objeto in LISTA)
            {
                comboBox1.Items.Add(objeto.getId() + " " + objeto.getNombre()+" "+ objeto.getApellido());
            }
        }

        private void agregar_Libro_Load(object sender, EventArgs e)
        {

        }

        private void titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion();
            bd.consulta("INSERT INTO libros VALUES(NULL,'"+titulo.Text+"','"+categoria.Text+"','"+cant_hojas.Text+"','"+null+"','"+editorial.Text+"','"+precio.Text+"','"+año.Text+"','"+indice.Text+"','"+stock.Text+"');");
            List<string> lista = bd.consulta("SELECT id_libro FROM libros WHERE titulo='" + titulo.Text + "';");

            string id = lista[0];
            bd.consulta("INSERT INTO libroautor SET libros_id_libro='" + id + "',autores_id_autores='" + autor.getId() + "';");
            bd.cerrarConexion();
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.autor = new Autor();
            String[] splitted = comboBox1.Text.Split(' ');
            this.autor.setId(int.Parse(splitted[0]));
            this.autor.setNombre(splitted[1]);
            this.autor.setApellido(splitted[2]);
        }
    }
}
