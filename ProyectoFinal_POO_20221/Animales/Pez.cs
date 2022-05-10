using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_POO_20221
{
    internal class Pez : Animal
    {
        public Pez(string nombre, string edad, string raza, string dueño, string tel_contacto) : base(nombre, edad, raza, dueño, tel_contacto)
        {
        }

        public override void Premiar()
        {
            base.Premiar();
            Console.WriteLine("       Se le nota feliz con su nueva decoración para pecera.");
        }
    }
}
