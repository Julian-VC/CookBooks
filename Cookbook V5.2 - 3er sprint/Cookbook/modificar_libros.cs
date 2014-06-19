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
    public partial class modificar_libros : Form
    {
        string id;
        string buscado;
        List<libros> LISTA = new List<libros>();

        List<Autor> LISTAAutor = new List<Autor>();
        Autor autorElegido;
        public modificar_libros()
        {
            InitializeComponent();
        }

       
        class libros
        {
            string id;
            string nombre;
            string categoria;
            string cant_hojas;
            string editorial;
            string precio;
            string año;
            string indice;
            string stock;
            public libros()
            {

            }
            public void agregar(string id,string nombre, string categoria,
            string cant_hojas,
            string editorial,
            string precio,
            string año,
            string indice,
            string stock)
            {
                this.id = id;
                this.nombre = nombre;
                this.categoria = categoria;
                this.cant_hojas = cant_hojas;
                this.editorial = editorial;
                this.precio = precio;
                this.año = año;
                this.indice = indice;
                this.stock = stock;

            }
            public string getNombre()
            {
                return this.nombre;
            }
            public string getId() {
                return this.id;
            }

        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox1.Text;
            string[] splitted=combo.Split(':');
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM libros WHERE id_libro='" + Convert.ToInt32(splitted[0]) + "';");

            id = lista[0];
            titulo.Text= lista[1];
            categoria.Text= lista[2];
            cant_hojas.Text = lista[3];
            editorial.Text = lista[5];
            precio.Text = lista[6];
            año.Text = lista[7];
            indice.Text = lista[8];
            stock.Text = lista[9];

            lista = bd.consulta("SELECT * FROM libroautor WHERE libros_id_libro='" + id + "';");

            lista= bd.consulta("SELECT * FROM autores WHERE id_autores='"+lista[1]+"';");
            try
            {
                comboBox2.Text = lista[0] + " " + lista[1] + " " + lista[2];
                autorElegido = new Autor();
                autorElegido.setId(int.Parse(lista[0]));
                autorElegido.setNombre(lista[1]);
                autorElegido.setApellido(lista[2]);
            }
            catch (Exception ex)
            {
            }
            lista = bd.consulta("SELECT * FROM autores;");
            for (int i = 0; i < lista.Count; i = i + 3)
            {
                Autor autor = new Autor();
                autor.setId(int.Parse(lista[i]));
                autor.setNombre(lista[i + 1]);

                autor.setApellido(lista[i + 2]);
                LISTAAutor.Add(autor);
            }
            foreach (Autor objeto in LISTAAutor)
            {
                comboBox2.Items.Add(objeto.getId() + " " + objeto.getNombre() + " " + objeto.getApellido());
            }
            
        }
        public void buscar()
        {

            foreach (libros objeto in LISTA)
            {
                comboBox1.Items.Add(objeto.getId()+":"+objeto.getNombre());
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            
            Conexion bd = new Conexion();
            bd.consulta("UPDATE  libros SET titulo='" + titulo.Text + "', categoria='" + categoria.Text + "',cant_hojas='"+cant_hojas.Text+"',editorial='"+editorial.Text+"',precio='"+float.Parse(precio.Text)+"',año='"+año.Text+"',indice='"+indice.Text+"',stock='"+stock.Text+"' where id_libro = '" +id +"';");
            bd.consulta("UPDATE  libroautor SET autores_id_autores='" + autorElegido.getId() + "' where libros_id_libro = '" + id + "';");
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void modificar_libros_Load(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libros nuevo = new libros();
            buscado = buscador.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM libros WHERE titulo LIKE'%" + buscado + "%';");
            for (int i = 0; i < lista.Count; i = i + 10)
            {
                string id = lista[i];
                string nombre = lista[i + 1];
                
                string categoria = lista[i + 2];
                string cant_hojas = lista[i + 3];
                string editorial = lista[i + 5];
                string precio = lista[i + 6];
                string año = lista[i + 7];
                string indice = lista[i + 8];
                string stock = lista[i + 9];

                nuevo.agregar(id, nombre, categoria, cant_hojas, editorial, precio, año, indice, stock);
                LISTA.Add(nuevo);
            }
            this.buscar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox2.Text;
            string[] splitted = combo.Split(' ');
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM autores WHERE id_autores='" + Convert.ToInt32(splitted[0]) + "';");

            Autor autor = new Autor();
            autor.setId(int.Parse(lista[0]));
            autor.setNombre(lista[1]);
            autor.setApellido(lista[2]);

            autorElegido=autor;
        }
    }
}