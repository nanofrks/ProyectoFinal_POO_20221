using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class Gato : Animal
    {
        private bool esterilizado;
        public Gato(string nombre, string edad, string raza, bool esterilizado, string dueño, string tel_contacto) : base(nombre, edad, raza, dueño, tel_contacto)
        {
            this.Esterilizado = esterilizado;
        }

        public bool Esterilizado { get => esterilizado; private set => esterilizado = value; }

        public override void Vacunar()
        {
            base.Vacunar();
            Console.WriteLine("       Se ha aplicado la vacuna de forma intramuscular.");
        }

        public override void Premiar()
        {
            base.Premiar();
            Console.WriteLine("       Salta de felicidad al oler el manjar que le han preparado");
        }
    }
}
