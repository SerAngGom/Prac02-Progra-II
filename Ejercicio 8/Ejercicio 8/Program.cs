using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 8, 8, 2, 4, 4, 2 }, { 0, 0, 0, 4, 6, 2 }, { 0, 0, 0, 0, 2, 2 } };
            SumarIgualesFil(matriz);
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

        public static void SumarIgualesFil(int[,] matriz)
        {
            DesplazarceroFil(matriz);
            int sum;
            for (int fil = 0; fil < matriz.GetLength(0); fil++)
            {
                for (int col = 0; col < matriz.GetLength(1) - 1; col++)
                {
                    if (matriz[fil, col] == matriz[fil, col+1])
                    {
                        sum = matriz[fil, col] * 2;
                        matriz[fil, col+1] = sum;
                        matriz[fil, col] = 0;
                    }
                }
            }
            DesplazarceroFil(matriz);
        }

        public static void DesplazarceroFil(int[,] matriz)
        {
            int aux;
            for (int fil = 0; fil < matriz.GetLength(0); fil++)
            {
                for (int col = 1; col < matriz.GetLength(1); col++)
                {
                    if (matriz[fil, col] == 0 && matriz[fil, col - 1] != 0)
                    {
                        while (col != 0 && matriz[fil, col - 1] != 0)
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
