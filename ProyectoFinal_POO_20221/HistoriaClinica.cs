using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoFinal_POO_20221
{ 
    internal class HistoriaClinica : IEscrituraArchivo
    {
        public void Escribir(Consulta con)
        {
            try 
            {
                StreamWriter sw = new StreamWriter(@"..\\..\\..\\..\\HistoriasClinicas\" + con.Paciente.Nombre + ".txt");

                DateTime dateTime = DateTime.Now;

                sw.WriteLine($"\n║  {dateTime}  ║ " +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╗" +
                    $"\n║                                                                                   ║" +
                    $"\n║                           HISTORIA CLÍNICA DEL PACIENTE                           ║" +
                    $"\n║                                                                                   ║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╣" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╣" +
                    $"\n║                              INFORMACIÓN DEL DOCTOR                               ║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╝" +
                    $"\n║" +
                    $"\n║   NOMBRE  {con.Doctor.Nombre}" +
                    $"\n║   IDENTIFICACIÓN  {con.Doctor.Identificacion}" +
                    $"\n║   CORREO ELECTRÓNICO  {con.Doctor.Correo_electronico}" +
                    $"\n║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╗" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╣" +
                    $"\n║                             INFORMACIÓN DEL PACIENTE                              ║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╝" +
                    $"\n║" +
                    $"\n║   CÓDIGO  {con.Paciente.Código}" +
                    $"\n║   NOMBRE  {con.Paciente.Nombre}" +
                    $"\n║   RESPONSABLE  {con.Paciente.Dueño}   TEL. CONTACTO  {con.Paciente.Tel_contacto}" +
                    $"\n║   EDAD  {con.Paciente.Edad}" +
                    $"\n║   RAZA  {con.Paciente.Raza}" +
                    $"\n║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╗" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╣" +
                    $"\n║                             DETALLES DEL TRATAMIENTO                              ║" +
                    $"\n╠═══════════════════════════════════════════════════════════════════════════════════╝" +
                    $"\n{con.Tratamiento}" +
                    $"\n" +
                    $"\n╚═══════════════════════════════════════════════════════════════════════════════════╝");

                sw.Close();

                Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════════════╗" +
                                    "\n║            Se ha generado el archivo con la historia clínica exitosamente          ║" +
                                    "\n╚════════════════════════════════════════════════════════════════════════════════════╝");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error "+ex);
            }
        }

        public List<Doctor> LeerArchivo()
        {
            throw new NotImplementedException();
        }
    }
}
