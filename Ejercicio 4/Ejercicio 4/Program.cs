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
            Calle c1 = new Calle(140, 2, "Calle A", "s1", NivelesOcupacion.Rojo);
            Calle c2 = new Calle(150, 3, "Calle B", "s2", NivelesOcupacion.Rojo);
            Calle c3 = new Calle(120, 2, "Calle C", "s3", NivelesOcupacion.Verde);
            Calle c4 = new Calle(140, 2, "Calle D", "s4", NivelesOcupacion.Rojo);
            Calle c5 = new Calle(140, 2, "Calle E", "s5", NivelesOcupacion.Rojo);

            Calle[] Calles= { c1, c2, c3, c4,c5 };
            Calle[] CallesEntrada = { c1, c2, c3 };
            Calle[] CallesSalida = { c4, c5 };

            Cruce cruce= new Cruce("Cruce ABCDE", "c1", CallesEntrada, CallesSalida);

            foreach( Calle c in Calles )
            {
                Console.WriteLine(c.Codigo);
                Console.WriteLine(c.Nombre);
                Console.WriteLine(c.longitud);
                Console.WriteLine(c.Ncarriles);
                Console.WriteLine(c.ocupacion);
                Console.WriteLine("----------------------------------------------");
            }
            Console.WriteLine(cruce.Codigo);
            Console.WriteLine(cruce.nombre);
            Console.WriteLine(cruce.Congestionada(CallesEntrada, CallesSalida));
            Console.ReadKey();
        }
    }
}



