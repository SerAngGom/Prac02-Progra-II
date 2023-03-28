using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_4.Program;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public enum NivelesOcupacion { Verde, Amarillo, Rojo }

        public class Calle
        {
            private int longitud { get; set; }
            private int Ncarriles { get; set; }
            private String Nombre { get; set; }
            private String Codigo { get; set; }
            private NivelesOcupacion ocupacion { get; }
            public Calle(int longitud, int Ncarriles, String Nombre, String Codigo, NivelesOcupacion ocupacion)
            {
                this.longitud = longitud;
                this.Ncarriles = Ncarriles;
                this.Nombre = Nombre;
                this.Codigo = Codigo;
                this.ocupacion = ocupacion;
            }
        }

        public class Cruce
        {
            private String nombre { get; set; }
            private String Codigo { get; set; }
            private Calle[] CallesEntrada { get; set; }

            private Calle[] CallesSalida { get; set; }

        }
    }
}

//public bool Congestionada(Calle[] CallesEntrada, Calle[] CallesSalida)
//{
//                private int contEntrada;
//private int contSalida;
//
//foreach (Calle C in CallesEntrada)
//{
//    if (C.NivelesOcupacion == Rojo)
//        contEntrada++;
//}
//foreach (Calle C in CallesSalida)
//{
//    if (C.NivelesOcupacion == Rojo)
//        contSalida++;
//
//}
//if (contEntrada >= CallesEntrada.Lenght() && contSalida >= CallesSalida.Lenght())
//{
//    return true
//}
//else{return false}

