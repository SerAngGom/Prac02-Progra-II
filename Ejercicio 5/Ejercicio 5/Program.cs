using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args) {
            int[,] matriz = { { 4, 0, 4, 2, 0, 2 }, { 4, 6, 0, 2, 0, 0 } ,{ 0, 0, 0, 8, 2, 0 } };
            DesplazarceroCol(matriz);
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


        public static void DesplazarceroCol(int[,] matriz) 
        { 
            int aux;
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                for (int fil = 1; fil < matriz.GetLength(0); fil++)
                {
                    if (matriz[fil, col] == 0 && matriz[fil-1, col] != 0)
                    {
                        while (fil != 0 && matriz[fil -1, col ] != 0)
                        {
                            aux = matriz[fil -1, col ];
                            matriz[fil, col] = aux;
                            matriz[fil -1, col] = 0;
                            fil--;
                        }
                    }
                }
            }
        }
    }
        
}

