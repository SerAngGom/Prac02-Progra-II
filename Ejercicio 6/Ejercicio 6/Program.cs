using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        int[,] matriz = { { 8, 0, 4, 4, 0, 2 }, { 4, 6, 0, 2, 0, 0 }, { 0, 0, 0, 8, 2, 0 } };
        static void Main(string[] args)
        {
            int[,] matriz = { { 8, 0, 4, 4, 0, 2 }, { 4, 6, 0, 2, 0, 0 }, { 0, 0, 0, 8, 2, 0 } };
            desplazarcerofil(matriz);
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        
        public static void desplazarcerofil(int[,] matriz)
        {
            int aux;
            for (int fil = 0; fil < matriz.GetLength(0); fil++)
            {
                for (int col = 1; col < matriz.GetLength(1); col++)
                {
                    if (matriz[fil,col] == 0 && matriz[fil, col-1]!=0)
                    {
                        while ( col != 0  && matriz[fil, col - 1] != 0 )
                        {
                            aux = matriz[fil, col - 1];
                            matriz[fil, col] = aux;
                            matriz[fil, col - 1] = 0;
                            col--;
                        }
                    }
                }
            }
        }
    }

}
