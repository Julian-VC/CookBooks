using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class Autor
    {
        private String nombre;
        private String apellido;
        private int id;

        public void setNombre(string nombre){
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public String getApellido()
        {
            return this.apellido;
        }
        public int getId()
        {
            return this.id;
        }
        public void agregar(int id, string nombre, string apellido)
        {
            this.id=id;
            this.nombre = nombre;
            this.apellido = apellido;

        }
    }
}
