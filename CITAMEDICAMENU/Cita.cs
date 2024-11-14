using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITAMEDICAMENU
{
    public class Cita
    {
        public int Numero { get; set; }
        public Estudiante Estudiante { get; set; }
        public string Enfermedad { get; set; }
        public double Precio { get; set; }

        public Cita(int numero, Estudiante estudiante, string enfermedad, double precio)
        {
            Numero = numero;
            Estudiante = estudiante;
            Enfermedad = enfermedad;
            Precio = precio;
        }
    }
}
