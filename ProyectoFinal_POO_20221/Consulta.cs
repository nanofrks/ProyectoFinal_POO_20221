using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class Consulta
    {
        private DateTime fecha;
        private Animal paciente;
        private Doctor doctor;
        private StringBuilder tratamiento = new StringBuilder();

        public Consulta()
        {
            this.Fecha = DateTime.Now;
        }

        public DateTime Fecha { get => fecha; private set => fecha = value; }
        public StringBuilder Tratamiento { get => tratamiento; private set => tratamiento = value; }
        internal Animal Paciente { get => paciente; set => paciente = value; }
        internal Doctor Doctor { get => doctor; set => doctor = value; }

        public void AñadirTratamiento(string t)
        {
            tratamiento.Append("\n" + t);
        }
    }
}
