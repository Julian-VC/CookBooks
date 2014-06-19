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
    public partial class Autores_abm : Form
    {
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
            public void agregar(string id, string nombre, string categoria,
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
            public string getCategoria()
            {
                return this.categoria;
            }
            public string getCantHojas()
            {
                return this.cant_hojas;
            }
            public string getEditorial()
            {
                return this.editorial;
            }
            public string getPrecio()
            {
                return this.precio;
            }
            public string getAño()
            {
                return this.año;
            }
            public string getIndice()
            {
                return this.indice;
            }
            public string getStock()
            {
                return this.stock;
            }
            public string getId()
            {
                return this.id;
            }

        }
        public Autores_abm()
        {
            InitializeComponent();
            mostrarLibros();
            mostrarAutores();
        }

        private void mostrarLibros()
        {
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM libros");
            libros libro = new libros();
            List<string> columnas = new List<string> { "id", "Nombre", "Categoria", "Cant Hojas", "Editorial", "Precio", "Año", "Stock" };

            foreach (String columna in columnas)
            {
                DataGridViewColumn nueva = new DataGridViewTextBoxColumn();
                nueva.Name = columna;
                nueva.DataPropertyName = columna;
                nueva.HeaderText = columna;
                dataGridView1.Columns.Add(nueva);
            }

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

                libro.agregar(id, nombre, categoria, cant_hojas, editorial, precio, año, indice, stock);


                dataGridView1.Rows.Add(libro.getId(), libro.getNombre(), libro.getCategoria(), libro.getCantHojas(), libro.getEditorial(), libro.getPrecio(), libro.getAño(), libro.getStock());
            }
            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSize = false;
            // Configure the details DataGridView so that its columns automatically 
            // adjust their widths when the data changes.
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void mostrarAutores()
        {
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM autores");
            Autor autor = new Autor();
            List<string> columnas = new List<string> { "id", "Nombre", "Apellido" };

            foreach (String columna in columnas)
            {
                DataGridViewColumn nueva = new DataGridViewTextBoxColumn();
                nueva.Name = columna;
                nueva.DataPropertyName = columna;
                nueva.HeaderText = columna;
                dataGridView2.Columns.Add(nueva);
            }

            for (int i = 0; i < lista.Count; i = i + 3)
            {
                string id = lista[i];
                string nombre = lista[i + 1];
                string apellido = lista[i + 2];
                
                autor.setId(int.Parse(id));
                autor.setNombre(nombre);
                autor.setApellido(apellido);

                dataGridView2.Rows.Add(autor.getId(), autor.getNombre(), autor.getApellido());
            }
            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSize = true;
            // Configure the details DataGridView so that its columns automatically 
            // adjust their widths when the data changes.
            dataGridView2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            agregar_autores agregar = new agregar_autores();
            agregar.ShowDialog();

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            autor_modificar modificar = new autor_modificar();
            modificar.ShowDialog();
        }

        private void Autores_abm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            agregar_Libro agregar = new agregar_Libro();
            agregar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            modificar_libros modificar = new modificar_libros();
            modificar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            libros_eliminar eliminar = new libros_eliminar();
            eliminar.ShowDialog();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            autores_eliminar eliminar = new autores_eliminar();
            eliminar.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            eliminar_usuario eliminar = new eliminar_usuario();
            eliminar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            modificar_usuario modificar = new modificar_usuario();
            modificar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            agregar_usuario agregar = new agregar_usuario();
            agregar.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
