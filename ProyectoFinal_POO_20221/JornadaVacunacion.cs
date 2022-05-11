using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoFinal_POO_20221
{
    internal class JornadaVacunacion: IEscrituraArchivo
    {
        private DateTime fecha;
        private List<Animal> animalesInscritos = new List<Animal>();

        public JornadaVacunacion()
        {
            this.Fecha = DateTime.Now;
        }

        public DateTime Fecha { get => fecha; private set => fecha = value; }
        internal List<Animal> AnimalesInscritos { get => animalesInscritos; private set => animalesInscritos = value; }

        public void Escribir(Consulta con)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"..\\..\\..\\..\\JornadasVacunacion_" + this.Fecha.Month + this.Fecha.Day + ".txt");

                DateTime dateTime = DateTime.Now;

                sw.WriteLine($"\n║  {dateTime}  ║ " +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╗" +
                    $"\n║                                                                                   ║" +
                    $"\n║                                ANIMALES VACUNADOS                                 ║" +
                    $"\n║                                                                                   ║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╣");

                foreach (var item in AnimalesInscritos)
                {
                    sw.WriteLine($"\n  ---------------------------------------------------" +
                                                    $"\n  [ ESPECIE ] : {item.GetType().Name}" +
                                                    $"\n  [ CÓDIGO ] : {item.Código}" +
                                                    $"\n  [ NOMBRE ] : {item.Nombre}" +
                                                    $"\n  [ EDAD ] : {item.Edad}" +
                                                    $"\n  [ RAZA ] : {item.Raza}" +
                                                    $"\n  [ DUEÑO ] : {item.Dueño}" +
                                                    $"\n  ---------------------------------------------------");
                }

                sw.WriteLine("\n╚═══════════════════════════════════════════════════════════════════════════════════╝");

                sw.Close();

                Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════════════╗" +
                                    "\n║         Se ha generado el archivo con el registro de la jornada exitosamente       ║" +
                                    "\n╚════════════════════════════════════════════════════════════════════════════════════╝");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error " + ex);
            }
        }

        public void Inscribir(Animal a)
        {
            this.AnimalesInscritos.Add(a);
        }

        public void VerInscritos(Animal item)
        {
            Console.WriteLine($"\n  ---------------------------------------------------" +
                                                    $"\n  [ ESPECIE ] : {item.GetType().Name}" +
                                                    $"\n  [ CÓDIGO ] : {item.Código}" +
                                                    $"\n  [ NOMBRE ] : {item.Nombre}" +
                                                    $"\n  [ EDAD ] : {item.Edad}" +
                                                    $"\n  [ RAZA ] : {item.Raza}" +
                                                    $"\n  [ DUEÑO ] : {item.Dueño}" +
                                                    $"\n  ---------------------------------------------------");
        }
    }
}
