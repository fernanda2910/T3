using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITAMEDICAMENU
{
    public class Estudiante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Universidad { get; set; }

        public Estudiante(int codigo, string nombre, string universidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Universidad = universidad;
        }
    }
}
