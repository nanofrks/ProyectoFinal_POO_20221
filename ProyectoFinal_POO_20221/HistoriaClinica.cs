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

                sw.WriteLine(dateTime
                            + "\n" + con.Doctor.Nombre
                            + "\n" + con.Doctor.Identificacion
                            + "\n" + con.Doctor.Correo_electronico
                            + "\n\nAtendiendo a" + con.Paciente.Nombre
                            + "\nA nombre de " + con.Paciente.Dueño + " Telefono: " + con.Paciente.Tel_contacto
                            + "\n\nDatos del paciente:"
                            + "\nEdad:" + con.Paciente.Edad
                            + "\nRaza:" + con.Paciente.Raza
                            + "\n\nTratamiento recetado: " + con.Tratamiento);
                sw.Close();
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
