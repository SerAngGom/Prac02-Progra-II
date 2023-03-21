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
            int[] list = { -1, 2, 3, 4, -5, 6, 7, -8, 9, 10, 11, -12, 13, -14, };
            int pos = list.Length-1;
            Program p = new Program();
            Console.WriteLine(p.CuentaPositivos(pos, list));
            Console.ReadKey();
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
