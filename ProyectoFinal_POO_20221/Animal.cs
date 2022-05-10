using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class Animal
    {
        private string código;
        private string nombre;
        private string edad;
        private string raza;
        private string dueño;
        private string tel_contacto;
        private HistoriaClinica historiaClinica;

        Random r = new Random();

        public Animal(string nombre, string edad, string raza, string dueño, string tel_contacto)
        {
            this.Código = r.Next(1000, 9999).ToString();
            this.Nombre = nombre;
            this.Edad = edad;
            this.Raza = raza;
            this.Dueño = dueño;
            this.Tel_contacto = tel_contacto;
            historiaClinica = new HistoriaClinica();
        }

        public string Código { get => código; private set => código = value; }
        public string Nombre { get => nombre; private set => nombre = value; }
        public string Edad { get => edad; private set => edad = value; }
        public string Raza { get => raza; private set => raza = value; }
        public string Dueño { get => dueño; private set => dueño = value; }
        public string Tel_contacto { get => tel_contacto; private set => tel_contacto = value; }
        internal HistoriaClinica HistoriaClinica { get => historiaClinica; set => historiaClinica = value; }

        public virtual void Vacunar()
        {
            Console.WriteLine($"\n       Vacunando a {this.Nombre} ...");
        }

        public virtual void Premiar()
        {
            Console.WriteLine($"\n       ¡Se le ha dado un premio a {this.Nombre}!");
        }
    }
}
