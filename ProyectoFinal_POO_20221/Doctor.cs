using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class Doctor
    {
        private string nombre;
        private int edad;
        private string identificacion;
        private string correo_electronico;

        public Doctor(string nombre, int edad, string identificacion, string correo_electronico)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Identificacion = identificacion;
            this.Correo_electronico = correo_electronico;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
    }
}
