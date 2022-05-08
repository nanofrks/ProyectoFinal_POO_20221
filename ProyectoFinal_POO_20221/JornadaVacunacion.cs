using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class JornadaVacunacion
    {
        private DateTime fecha;
        private double costo;
        private List<Animal> animalesInscritos = new List<Animal>();

        public JornadaVacunacion()
        {
            this.Fecha = DateTime.Now;
            this.Costo = 35000;
        }

        public DateTime Fecha { get => fecha; private set => fecha = value; }
        public double Costo { get => costo; private set => costo = value; }
        internal List<Animal> AnimalesInscritos { get => animalesInscritos; private set => animalesInscritos = value; }

        public void Inscribir(Animal a)
        {
            this.AnimalesInscritos.Add(a);
        }
    }
}
