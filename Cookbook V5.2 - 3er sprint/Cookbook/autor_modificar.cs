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
    public partial class autor_modificar : Form
    {
        List<Autor> LISTA = new List<Autor>();
        String nombre;
        int idElegido;
        string buscado;
        public autor_modificar()
        {
            InitializeComponent();
            
        }

        private void autor_modificar_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Autor nuevo=new Autor();
            buscado=textBox3.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM autores WHERE apellido LIKE '%" + buscado + "%' OR nombre LIKE '%" + buscado + "%';");
           for (int i = 0; i < lista.Count; i = i + 3) {
                string id = lista[i];
                string nombre = lista[i+1];
                string apellido = lista[i+2];
                nuevo.agregar(int.Parse(id), nombre, apellido);
                LISTA.Add(nuevo);
            }
           this.buscar();
        }
        class autores {
            string id;
            string nombre;
            string apellido;
            public autores() {
               
            }
            public void agregar(string id,string nombre,string apellido){
                 this.id=id;
                this.nombre=nombre;
                this.apellido=apellido;
    }
        public string getApellido(){
            return this.apellido;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         string combo = comboBox1.Text;
         string[] splitted = combo.Split(' ');
         Autor elegido = LISTA[Convert.ToInt32(splitted[0])];
         idElegido = elegido.getId();
         textBox1.Text = elegido.getNombre();
         textBox2.Text = elegido.getApellido();
        }
        public void buscar(){
            
                foreach (Autor objeto in LISTA)
                {
                    comboBox1.Items.Add(LISTA.IndexOf(objeto) +" "+objeto.getNombre());
                }
            }

        private void modificar_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion();
            bd.consulta("UPDATE  autores SET nombre='" + textBox1.Text + "', apellido='" + textBox2.Text + "' where id_autores = '" + idElegido + "';");
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autores_abm mer = new Autores_abm();
            mer.ShowDialog();
        }
        }

    }

