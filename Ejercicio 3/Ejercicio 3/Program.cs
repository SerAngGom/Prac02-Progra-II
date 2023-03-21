using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] M = { { 1, 2, 3 }, { 4, 5, 6 } };
            int n = 5;
            int posx = 0;
            int posy = 0;
            Program program= new Program();
            Console.WriteLine(program.ContenM( M, n, posx, posy));
            Console.ReadKey();  

        }

        public bool ContenM(float[,] M, int n, int posx, int posy)
        {
            if (M[posx,posy] == n)
            {
                return true;
            }
            else if (posx < M.GetLength(0)-1)
            {
                posx++;
                return ContenM( M, n, posx, posy);
            }
            else if(posy < M.GetLength(1)-1)
            {
                posx = 0;
                posy++;
                return ContenM( M, n, posx, posy);
            }
            return false;

        }
    }
}
