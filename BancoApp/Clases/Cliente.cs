using System;
using System.Collections.Generic;
using System.Text;

namespace BancoApp.Clases
{
    class Cliente
    {
        private string nombre;
        private string correo;
        private string telefono;


        public Cliente( string nombre, string correo, string telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getCorreo()
        {
            return this.correo;
        }
        public string getTelefono()
        {
            return this.telefono;
        }



    }
}
