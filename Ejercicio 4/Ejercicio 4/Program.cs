using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public enum NivelesOcupacion { Verde, Amarillo, Rojo}

        public class Calle
        {
            private int longitud;
            private int Ncarriles;
            private String Nombre;
            private String Codigo;
            private NivelesOcupacion ocupacion;
            public Calle(longitud, Ncarriles, Nombre, Codigo, ocupacion)
            {
                this.longitud = longitud;
                this.Ncarriles = Ncarriles;
                this.Nombre = Nombre;
                this.Codigo = Codigo;
                this.ocupacion = ocupacion;
            }
        }
    }
}
