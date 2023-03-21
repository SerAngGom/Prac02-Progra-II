using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CuentaPositivos(5, int[2,4]));
        }
        public int CuentaPositivos(int pos, int[] a)
        {
            if (pos < 0)
            {
                return 0;
            }
            else
            {
                if (a[pos] > 0)
                {
                    return 1 + CuentaPositivos(pos - 1, a);
                }
                else
                {
                    return CuentaPositivos(pos - 1, a);
                }
            }
        }
        
    }
}
