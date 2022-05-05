using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class Roedor : Animal
    {
        private bool esterilizado;
        public Roedor(string nombre, string edad, string raza, bool esterilizado, string dueño, string tel_contacto) : base(nombre, edad, raza, dueño, tel_contacto)
        {
            this.Esterilizado = esterilizado;
        }

        public bool Esterilizado { get => esterilizado; private set => esterilizado = value; }
    }
}
