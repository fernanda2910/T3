using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITAMEDICAMENU
{
    public static class CreadorCitas
    {
        public static void CrearCita(Cita[] citas, ref int contadorCitas)
        {
            if (contadorCitas >= citas.Length)
            {
                Console.WriteLine("NO HAY ESPACIO PARA MAS CITAS");
                return;
            }
            Console.WriteLine("INGRESE EL CODIGO DEL ESTUDIANTE:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL NOMBRE DEL ESTUDIANTE");
            string nombre = Console.ReadLine();
            Console.WriteLine("INGRESE LA UNIVERSIDAD DEL ESTUDIANTE:");
            string universidad = Console.ReadLine();
            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);
            Console.WriteLine("INGRESE EL NUMERO DE LA CITA");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU ENFERMEDAD:");
            string enfermedad = Console.ReadLine();
            Console.WriteLine("INGRESE EL PRECIO DE SU CITA:");
            double precio = double.Parse(Console.ReadLine());
            Cita nuevaCita = new Cita(numero, estudiante, enfermedad, precio);
            citas[contadorCitas] = nuevaCita;
            contadorCitas++;
            Console.WriteLine("CITA CREADA");
        }
        public static void ListarCitas(Cita[] citas, int contadorCitas)
        {
            if (contadorCitas == 0)
            {
                Console.WriteLine("NO HAY CITA REGISTRADA");
                return;
            }
            double totalPrecio = 0;
            for (int i = 0; i < contadorCitas; i++)
            {
                Cita cita = citas[i];
                Console.WriteLine($"Cita #{cita.Numero} - Enfermedad: {cita.Enfermedad}, Estudiante: {cita.Estudiante.Nombre} ({cita.Estudiante.Codigo}), Universidad: {cita.Estudiante.Universidad}, Precio: {cita.Precio:C}");
                totalPrecio += cita.Precio;
            }
            Console.WriteLine($"TOTAL DEL PRECIO: {totalPrecio:C}");
        }
        public static void ModificarMasivoUniversidad(Cita[] citas, int contadorCitas, string textoBuscar, string textoReemplazo)
        {
            for (int i = 0; i < contadorCitas; i++)
            {
                citas[i].Estudiante.Universidad = citas[i].Estudiante.Universidad.Replace(textoBuscar, textoReemplazo);
            }
            Console.WriteLine("MODIFICACION MASIVA REALIZADA");
        }
    }
}