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
    public partial class modificar_usuario : Form
    {

        List<usuario> LISTA = new List<usuario>();
        String nombre;
        string buscado;
        usuario elegido;


        public modificar_usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            usuario nuevo=new usuario();
            buscado=textBox3.Text;
            Conexion bd = new Conexion();
            List<string> lista = bd.consulta("SELECT * FROM usuario WHERE nomYape LIKE'%"+buscado+"%';");
           for (int i = 0; i < lista.Count; i = i + 8) {
                string email = lista[i];
                string nombreYapellido = lista[i+1];
                string pass = lista[i+2];
                string direccion = lista[i + 3];
                string fechaNacimiento = lista[i + 4];
                int telefono = int.Parse(lista[i + 5]);



                nuevo.agregar(email, nombreYapellido, pass, direccion, fechaNacimiento, telefono);
                LISTA.Add(nuevo);
            }
           this.buscar();
                 }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox1.Text;
            string[] splitted = combo.Split(':');
            elegido = LISTA[Convert.ToInt32(splitted[0])];
            
            textBox2.Text=elegido.getNombreYapellido();
            textBox3.Text=elegido.getPass();
            textBox4.Text=elegido.getDireccion();
            textBox5.Text=elegido.getFechaNacimiento();
            textBox6.Text = elegido.getTelefono().ToString();

        }
        public void buscar()
        {

            foreach (usuario objeto in LISTA)
            {
                int indx = LISTA.IndexOf(objeto);
                comboBox1.Items.Add(indx+":"+objeto.getNombreYapellido());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion bd = new Conexion();
            bd.consulta("UPDATE  usuario SET nomYape='" + textBox2.Text + "', pass='" + textBox3.Text + "', direccion='" + textBox4.Text + "', fechaNac='" + textBox5.Text + "', telefono='" + textBox6.Text + "' where email = '" + elegido.getEmail() + "';");
            MessageBox.Show("Usuario modificado correctamente.","Modificacion Usuario");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
        class usuario 
        {
            string email;
            string nombreYapellido;
            string pass;
            string direccion;
            string fechaNacimiento;
            int telefono;


            public usuario() {
               
            }
            public void agregar(string email,string nombreYapellido, string pass, string direccion,string fechaNacimiento, int telefono){
                this.email=email;
                this.nombreYapellido=nombreYapellido;
                this.pass=pass;
                this.direccion=direccion;
                this.telefono=telefono;
                this.fechaNacimiento = fechaNacimiento;
    }
        public string getNombreYapellido()
        {
            return this.nombreYapellido;
        }
        public string getPass()
        {
                    return this.pass;
        }
        public string getDireccion()
        {
            return this.direccion;
        }
        public int getTelefono(){
            return this.telefono;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        }
  
}
