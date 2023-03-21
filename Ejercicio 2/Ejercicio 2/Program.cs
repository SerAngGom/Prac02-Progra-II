using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[] { 1, 2, 4, 5, 7 };
            int cont = 0;
            double suma = 0;
            Program program= new Program();
            Console.WriteLine(program.Media(a, cont, suma));
            Console.ReadKey();
        }

        public double Media(double[] a, int cont, double suma)
        {
            if (cont < a.Length)
            {
                suma += a[cont];
                cont += 1;
                return Media(a, cont, suma);
            }
            else
            {
                return suma / a.Length;
            }
             
            
        }
    }
}
