using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Cruce
    {
        public String nombre { get; set; }
        public String Codigo { get; set; }
        public Calle[] CallesEntrada { get; set; }

        public Calle[] CallesSalida { get; set; }
        private int contEntrada;
        private int contSalida;
        public bool Congestionada(Calle[] CallesEntrada, Calle[] CallesSalida)
        {

            foreach (Calle C in CallesEntrada)
            {
                if (C.ocupacion == NivelesOcupacion.Rojo)
                    contEntrada++;
            }
            foreach (Calle C in CallesSalida)
            {
                if (C.ocupacion == NivelesOcupacion.Rojo)
                    contSalida++;

            }
            if (contEntrada >= CallesEntrada.Length && contSalida >= CallesSalida.Length)
            {
                return true;
            }
            else { return false; }
        }
    }
}
