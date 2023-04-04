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
        public Cruce(String nombre, String Codigo, Calle[] CallesEntrada, Calle[] CallesSalida)
        {
            this.nombre = nombre;
            this.Codigo = Codigo;
            this.CallesEntrada = CallesEntrada;
            this.CallesSalida = CallesSalida;
        }
        public bool Congestionada(Calle[] CallesEntrada, Calle[] CallesSalida)
        {
            contEntrada = 0;
            contSalida = 0;
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
            if (contEntrada >= CallesEntrada.Length/2 && contSalida >= CallesSalida.Length/2)
            {
                return true;
            }
            else { return false; }
        }
    }
}
