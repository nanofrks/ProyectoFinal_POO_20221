using System;
using System.Collections.Generic;

namespace ProyectoFinal_POO_20221
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Saludo();

                byte op = 0, op_esp = 0;
                bool esnro = false, esnro_esp = false;
                List<Animal> clientes = new List<Animal>();

                do
                {
                    Menu();
                    do
                    {
                        Console.Write("\n  [ Opción ] : ");
                        esnro = byte.TryParse(Console.ReadLine(), out op);
                        if (!esnro || op > 4 || op < 0)
                        {
                            Console.WriteLine("\n  [ Por favor ingrese una opción válida ]   ");
                        }
                    } while (!esnro || op > 4 || op < 0);

                    Console.Clear();

                    switch (op)
                    {
                        case 0: Despedida(); break;

                        case 1: 
                            //registra clientes nuevos en el sistema

                            Console.WriteLine("\n╔═══════════════════════════════════════════════════════════════════════════════════╗" +
                                "\n║                                                                                   ║" +
                                "\n║                       Ha seleccionado registrar paciente                          ║" +
                                "\n║                                                                                   ║" +
                                "\n╚═══════════════════════════════════════════════════════════════════════════════════╝");


                            Console.WriteLine("\n╔════════════════════════════════════╗" +
                                    "\n║       ¿Cuál es su especie?         ║" +
                                    "\n║════════════════════════════════════╣ " +
                                    "\n║ 1) Gato                            ║" +
                                    "\n║ 2) Perro                           ║" +
                                    "\n║ 3) Pájaro                          ║" +
                                    "\n║ 4) Roedor                          ║" +
                                    "\n║ 5) Pez                             ║" +
                                    "\n╚════════════════════════════════════╝");

                            do
                            {
                                Console.Write("\n  [ Opción ] : ");
                                esnro_esp = byte.TryParse(Console.ReadLine(), out op_esp);
                                if (!esnro_esp || op_esp > 5 || op_esp < 1)
                                {
                                    Console.WriteLine("\n  [ Por favor ingrese una opción válida ]   ");
                                }
                            } while (!esnro_esp || op_esp > 5 || op_esp < 1);

                            switch (op_esp)
                            {
                                case 1:
                                    Console.WriteLine("\n\n  ---------- DATOS DEL PACIENTE ----------  ");
                                    Console.Write("\n  [ Nombre ] : ");
                                    string nombre_gato = Console.ReadLine();
                                    Console.Write("  [ Edad ] : ");
                                    string edad_gato = Console.ReadLine();
                                    Console.Write("  [ Raza ] : ");
                                    string raza_gato = Console.ReadLine();
                                    string esterilizado_gato_txt;
                                    do
                                    {
                                        Console.Write("  [ ¿Está esterilizado? (SI/NO) ] : ");
                                        esterilizado_gato_txt = Console.ReadLine().ToUpper();
                                        if (esterilizado_gato_txt != "SI" && esterilizado_gato_txt != "NO")
                                        {
                                            Console.WriteLine("\n  [ Por favor ingrese una opción válida ]   \n");
                                        }
                                    } while (esterilizado_gato_txt != "SI" && esterilizado_gato_txt != "NO");

                                    bool esterilizado_gato = false;

                                    if (esterilizado_gato_txt.Equals("SI"))
                                    {
                                        esterilizado_gato = true;
                                    }
                                    else if (esterilizado_gato_txt.Equals("NO"))
                                    {
                                        esterilizado_gato = false;
                                    }

                                    Console.Write("  [ Nombre del responsable ] : ");
                                    string dueño_gato = Console.ReadLine();
                                    Console.Write("  [ Teléfono de contacto ] : ");
                                    string telefono_gato = Console.ReadLine();

                                    Animal gato = new Gato(nombre_gato, edad_gato, raza_gato, esterilizado_gato, dueño_gato, telefono_gato);
                                    clientes.Add(gato);
                                    Console.WriteLine($"\n  [ ¡Ha registrado correctamente a {gato.Nombre}! Su código de cliente es {gato.Código} ]");
                                    Console.WriteLine("\n" + @"      _._     _,-'''`-._" + 
                                        "\n" + @"     (,-.`._,'(       |\`-/|" +
                                        "\n" + @"         `-.-' \ )-`( , o o)" +
                                        "\n" + @"               `-    \`_`''-" );
                                    break;

                                case 2:
                                    Console.WriteLine("\n\n  ---------- DATOS DEL PACIENTE ----------  ");
                                    Console.Write("\n  [ Nombre ] : ");
                                    string nombre_perro = Console.ReadLine();
                                    Console.Write("  [ Edad ] : ");
                                    string edad_perro = Console.ReadLine();
                                    Console.Write("  [ Raza ] : ");
                                    string raza_perro = Console.ReadLine();
                                    string esterilizado_perro_txt;
                                    do
                                    {
                                        Console.Write("  [ ¿Está esterilizado? (SI/NO) ] : ");
                                        esterilizado_perro_txt = Console.ReadLine().ToUpper();
                                        if (esterilizado_perro_txt != "SI" && esterilizado_perro_txt != "NO")
                                        {
                                            Console.WriteLine("\n  [ Por favor ingrese una opción válida ]   \n");
                                        }
                                    } while (esterilizado_perro_txt != "SI" && esterilizado_perro_txt != "NO");

                                    bool esterilizado_perro = false;

                                    if (esterilizado_perro_txt.Equals("SI"))
                                    {
                                        esterilizado_perro = true;
                                    }
                                    else if (esterilizado_perro_txt.Equals("NO"))
                                    {
                                        esterilizado_perro = false;
                                    }

                                    Console.Write("  [ Nombre del responsable ] : ");
                                    string dueño_perro = Console.ReadLine();
                                    Console.Write("  [ Teléfono de contacto ] : ");
                                    string telefono_perro = Console.ReadLine();

                                    Animal perro = new Perro(nombre_perro, edad_perro, raza_perro, esterilizado_perro, dueño_perro, telefono_perro);
                                    clientes.Add(perro);
                                    Console.WriteLine($"\n  [ ¡Ha registrado correctamente a {perro.Nombre}! Su código de cliente es {perro.Código} ]");
                                    Console.WriteLine("\n" + @"          |\_/|                  " +
                                        "\n" + @"          | @ @   " +
                                        "\n" + @"          |   <>              _  " +
                                        "\n" + @"          |  _/\------____ ((| |))" +
                                        "\n" + @"          |               `--' |   " +
                                        "\n" + @"      ____|_       ___|   |___.' " +
                                        "\n" + @"     /_/_____/____/_______|");
                                    break;

                                case 3:
                                    Console.WriteLine("\n\n  ---------- DATOS DEL PACIENTE ----------  ");
                                    Console.Write("\n  [ Nombre ] : ");
                                    string nombre_pajaro = Console.ReadLine();
                                    Console.Write("  [ Edad ] : ");
                                    string edad_pajaro = Console.ReadLine();
                                    Console.Write("  [ Raza ] : ");
                                    string raza_pajaro = Console.ReadLine();
                                    string esterilizado_pajaro_txt;
                                    do
                                    {
                                        Console.Write("  [ ¿Está esterilizado? (SI/NO) ] : ");
                                        esterilizado_pajaro_txt = Console.ReadLine().ToUpper();
                                        if (esterilizado_pajaro_txt != "SI" && esterilizado_pajaro_txt != "NO")
                                        {
                                            Console.WriteLine("\n  [ Por favor ingrese una opción válida ]   \n");
                                        }
                                    } while (esterilizado_pajaro_txt != "SI" && esterilizado_pajaro_txt != "NO");

                                    bool esterilizado_pajaro = false;

                                    if (esterilizado_pajaro_txt.Equals("SI"))
                                    {
                                        esterilizado_pajaro = true;
                                    }
                                    else if (esterilizado_pajaro_txt.Equals("NO"))
                                    {
                                        esterilizado_pajaro = false;
                                    }

                                    Console.Write("  [ Nombre del responsable ] : ");
                                    string dueño_pajaro = Console.ReadLine();
                                    Console.Write("  [ Teléfono de contacto ] : ");
                                    string telefono_pajaro = Console.ReadLine();

                                    Animal pajaro = new Pajaro(nombre_pajaro, edad_pajaro, raza_pajaro, esterilizado_pajaro, dueño_pajaro, telefono_pajaro);
                                    clientes.Add(pajaro);
                                    Console.WriteLine($"\n  [ ¡Ha registrado correctamente a {pajaro.Nombre}! Su código de cliente es {pajaro.Código} ]");
                                    Console.WriteLine("\n" + @"                                ." + 
                                        "\n" + @"                               | \/|" +
                                        "\n" + @"       (\   _                  ) )|/|" +
                                        "\n" + @"           (/            _----. /.'.'" +
                                        "\n" + @"     .-._________..      .' @ _\  .'   " + 
                                        "\n" + @"     '.._______.   '.   /    (_| .')" + 
                                        "\n" + @"       '._____.  /   '-/      | _.' " +
                                        "\n" + @"        '.______ (         ) ) \" +
                                        "\n" + @"          '..____ '._       )  )" +
                                        "\n" + @"             .' __.--\  , ,  // ((" +
                                        "\n" + @"             '.'  mrf|  \/   (_.'(  " +
                                        "\n" + @"                     '   \ .' " +
                                        "\n" + @"                      \   (" +
                                        "\n" + @"                       \   '." +
                                        "\n" + @"                        \ \ '.)" +
                                        "\n" + @"                         '-'-'");
                                    break;

                                case 4:
                                    Console.WriteLine("\n\n  ---------- DATOS DEL PACIENTE ----------  ");
                                    Console.Write("\n  [ Nombre ] : ");
                                    string nombre_roedor = Console.ReadLine();
                                    Console.Write("  [ Edad ] : ");
                                    string edad_roedor = Console.ReadLine();
                                    Console.Write("  [ Raza ] : ");
                                    string raza_roedor = Console.ReadLine();
                                    string esterilizado_roedor_txt;
                                    do
                                    {
                                        Console.Write("  [ ¿Está esterilizado? (SI/NO) ] : ");
                                        esterilizado_roedor_txt = Console.ReadLine().ToUpper();
                                        if (esterilizado_roedor_txt != "SI" && esterilizado_roedor_txt != "NO")
                                        {
                                            Console.WriteLine("\n  [ Por favor ingrese una opción válida ]   \n");
                                        }
                                    } while (esterilizado_roedor_txt != "SI" && esterilizado_roedor_txt != "NO");

                                    bool esterilizado_roedor = false;

                                    if (esterilizado_roedor_txt.Equals("SI"))
                                    {
                                        esterilizado_roedor = true;
                                    }
                                    else if (esterilizado_roedor_txt.Equals("NO"))
                                    {
                                        esterilizado_roedor = false;
                                    }

                                    Console.Write("  [ Nombre del responsable ] : ");
                                    string dueño_roedor = Console.ReadLine();
                                    Console.Write("  [ Teléfono de contacto ] : ");
                                    string telefono_roedor = Console.ReadLine();

                                    Animal roedor = new Roedor(nombre_roedor, edad_roedor, raza_roedor, esterilizado_roedor, dueño_roedor, telefono_roedor);
                                    clientes.Add(roedor);
                                    Console.WriteLine($"\n  [ ¡Ha registrado correctamente a {roedor.Nombre}! Su código de cliente es {roedor.Código} ]");
                                    Console.WriteLine("\n" + @"                  (\-." +
                                        "\n" + @"                  / _`> .---------." +
                                        "\n" + @"          _)     / _)=  |'-------'|" +
                                        "\n" + @"         (      / _/    |O   O   o|" +
                                        "\n" + @"     jgs  `-.__(___)_   | o O . o |" +
                                        "\n" + @"                        `---------'");
                                    break;

                                case 5:
                                    Console.WriteLine("\n\n  ---------- DATOS DEL PACIENTE ----------  ");
                                    Console.Write("\n  [ Nombre ] : ");
                                    string nombre_pez = Console.ReadLine();
                                    Console.Write("  [ Edad ] : ");
                                    string edad_pez = Console.ReadLine();
                                    Console.Write("  [ Raza ] : ");
                                    string raza_pez = Console.ReadLine();
                                    Console.Write("  [ Nombre del responsable ] : ");
                                    string dueño_pez = Console.ReadLine();
                                    Console.Write("  [ Teléfono de contacto ] : ");
                                    string telefono_pez = Console.ReadLine();

                                    Animal pez = new Pez(nombre_pez, edad_pez, raza_pez, dueño_pez, telefono_pez);
                                    clientes.Add(pez);
                                    Console.WriteLine($"\n  [ ¡Ha registrado correctamente a {pez.Nombre}! Su código de cliente es {pez.Código} ]");
                                    Console.WriteLine("\n" + @"           /`·.¸" +
                                        "\n" + @"          /¸...¸`:·" +
                                        "\n" + @"      ¸.·´  ¸   `·.¸.·´)" + 
                                        "\n" + @"     : © ):´;      ¸  {" +
                                        "\n" + @"      `·.¸ `·  ¸.·´\`·¸)" +
                                        "\n" + @"          `\\´´\¸.·´");
                                    break;
                            }

                            Console.WriteLine("\n  [ Presione cualquier tecla para regresar al menú ]  ");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 2:
                            //crea doctores que trabajan en la clínica veterinaria
                            Console.WriteLine("\n╔═══════════════════════════════════════════════════════════════════════════════════╗" +
                                "\n║                                                                                   ║" +
                                "\n║                         Ha seleccionado añadir doctores                           ║" +
                                "\n║                                                                                   ║" +
                                "\n╚═══════════════════════════════════════════════════════════════════════════════════╝");
                            break;
                        case 3: //busca la historia clínica del paciente
                            //que se desee, y se muestra en pantalla
                            break;
                        case 4:
                            //cierra el día en la clínica y calcula la cantidad 
                            //total de ganancias en ese día
                            break;
                        default:
                            break;
                    }

                } while (op != 0);

            }
            catch (Exception error)
            {
                Console.WriteLine("\nHa ocurrido un error en el programa principal: " + error);
            }
        }
        public static void Saludo()
        {
            Console.WriteLine("\n   ──────▄▀▄─────▄▀▄" +
                "\n   ─────▄█░░▀▀▀▀▀░░█▄        miauuuu~!" +
                "\n   ─▄▄──█░░░░░░░░░░░█──▄▄    Bienvenidx a la clínica veterninaria nyanimalitos! <3" +
                "\n   █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");
        }

        public static void Despedida()
        {
            Console.WriteLine("\n" + @"          |\      _,,,---,,_" +
                "\n" + @"     ZZZzz /,`.-'`'    -.  ;-;;,_" +
                "\n" + @"          |,4-  ) )-,_. ,\ (  `'-'" +
                "\n" + @"         '---''(_/--'  `-'\_)    fL" +
                "\n     Gracias por usar nuestro programa. Chao!!");
        }

        public static void Menu()
        {
            Console.WriteLine("\n╔════════════════════════════╦══════════════════════════════════════════════════════╗" +
                "\n║      _  _                  ║  1) Registrar paciente                               ║" +
                "\n║     (o)(o)--.              ║  2) Añadir doctores                                  ║" +
                "\n" + @"║      \../ (  )hjw          ║  3) Iniciar consulta                                 ║" +
                "\n" + @"╠══════m\/m--m'`═════════════╣  4) Ver historia clínica                             ║" +
                "\n║                            ║                                                      ║" +
                "\n║         { MENÚ }           ║                                                      ║" +
                "\n║                            ║  0) SALIR                                            ║" +
                "\n╚════════════════════════════╩══════════════════════════════════════════════════════╝");
        }
    }
}
