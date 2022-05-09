using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoFinal_POO_20221.Archivos
{
    class LecturaDoctores : ILecturaArchivo
    {
        char del=';';
        List<Doctor> doctores=new List<Doctor>();
 
        public List<Doctor> LeerArchivo()
        {
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"..\\..\\..\\..\\Doctores.txt"))
                {
                    string[] cadena = line.Split(del);
                    doctores.Add(new Doctor(cadena[1], int.Parse(cadena[2]), cadena[0], cadena[3]));
                }

                return doctores;
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("\n  [ No se ha encontrado el archivo\nAsegurese que el archivo Doctores.txt se encuentra en la carpeta principal del programa ]  ");
                doctores.Clear();
                return doctores;
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("\n  [ Hubo un error en el formato del archivo, asegurese de que está bien escrito ]  ");
                doctores.Clear();
                return doctores;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("\n  [ Hubo un error en el formato del archivo, asegurese de que está bien escrito ]  ");
                doctores.Clear();
                return doctores;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n  [ Ha ocurrido un error  ]  \n" + ex);
                doctores.Clear();
                return doctores;
            }
        }
    }
}
