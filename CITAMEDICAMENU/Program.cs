using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITAMEDICAMENU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CUANTAS CITAS DESEA REGISTRAR:");
            int maxCitas = int.Parse(Console.ReadLine());
            Cita[] citas = new Cita[maxCitas]; 
            int contadorCitas = 0;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nM E N U");
                Console.WriteLine("1. CREAR CITA");
                Console.WriteLine("2. LISTAR CITA");
                Console.WriteLine("3. MODIFICAR");
                Console.WriteLine("4. FIN");
                Console.Write("SELECCIONE UNA OPCION: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CreadorCitas.CrearCita(citas, ref contadorCitas);
                        break;
                    case 2:
                        CreadorCitas.ListarCitas(citas, contadorCitas);
                        break;
                    case 3:
                        Console.WriteLine("INGRESE TEXTO A BUSCAR");
                        string buscar = Console.ReadLine();
                        Console.WriteLine("INGRESE TEXTO DE REMPLAZO");
                        string reemplazo = Console.ReadLine();
                        CreadorCitas.ModificarMasivoUniversidad(citas, contadorCitas, buscar, reemplazo);
                        break;
                    case 4:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("ERROR, OPCION NO VALIDA.");
                        break;
                }
                if (contadorCitas >= maxCitas)
                {
                    Console.WriteLine("SE HA ALCANDO EL LIMITE MAXIMO DE CITAS");
                    continuar = false; 
                }
            }
        }
    }
}
