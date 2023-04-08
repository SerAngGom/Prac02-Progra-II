using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        int[,] matriz = { { 4, 0, 4, 2, 0, 2 }, { 4, 16, 0, 2, 0, 0 }, { 0, 0, 0, 8, 2, 0 } };
        static void Main(string[] args) {
            int[,] matriz = { { 4, 0, 4, 2, 0, 2 }, { 4, 16, 0, 2, 0, 0 }, { 0, 0, 0, 8, 2, 0 } };
            desplazarcero(matriz);
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


        public static void desplazarcero(int[,] matriz) { 
            int aux;
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                for (int fil = 0; fil < matriz.GetLength(0)-1; fil++)
                {
                    if (matriz[fil, col] != 0 && matriz[matriz.GetLength(0)-1, col] == 0)
                    {
                        aux = matriz[fil, col]; 
                        matriz[fil, col] = matriz[matriz.GetLength(0) - 1, col];
                        matriz[matriz.GetLength(0) - 1, col] = aux;
                    }

                    else if (matriz[fil, col] != 0 && matriz[fil + 1, col] == 0)
                    {
                        aux = matriz[fil, col];
                        matriz[fil, col] = matriz[fil + 1, col];
                        matriz[fil + 1, col] = aux;
                    }
                }
            }
        }
    }
        
}

