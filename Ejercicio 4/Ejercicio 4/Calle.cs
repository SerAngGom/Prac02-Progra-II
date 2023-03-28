using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_4.Program;

namespace Ejercicio_4
{
    public class Calle
    {
        public int longitud { get; set; }
        public int Ncarriles { get; set; }
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public NivelesOcupacion ocupacion { get; }
        public Calle(int longitud, int Ncarriles, String Nombre, String Codigo, NivelesOcupacion ocupacion)
        {
            this.longitud = longitud;
            this.Ncarriles = Ncarriles;
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            this.ocupacion = ocupacion;
        }
    }
}

