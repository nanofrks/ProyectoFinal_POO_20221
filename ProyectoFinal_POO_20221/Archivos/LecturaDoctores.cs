using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoFinal_POO_20221.Archivos
{
    class LecturaDoctores : ILecturaArchivo
    {
        String texto;
        char del=';';
        List<Doctor> doctores=new List<Doctor>();
        public List<Doctor> LeerArchivo()
        {
            TextReader Leer = new StreamReader("Doctores.txt");

            do
            {
                texto = Leer.ReadLine();
                string[] cadena = texto.Split(del);

                doctores.Add(new Doctor(cadena[1], int.Parse(cadena[2]), cadena[0], cadena[3]));
                
            }
            while (string.IsNullOrWhiteSpace(texto));
            

            return doctores;

        }
    }
}
