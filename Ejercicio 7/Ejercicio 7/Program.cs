using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 2, 0, 0, 2, 0, 0}, { 4, 0, 0, 2, 0, 0 }, { 4, 16, 4, 8, 2, 2} };
            Sumar_Iguales(matriz);
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

        public static void Sumar_Iguales(int[,] matriz)
        { 
            int sum;
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                for (int fil = 0; fil < matriz.GetLength(0)-1; fil++)
                {
                    if (matriz[fil, col] == matriz[fil+1,col])
                    {
                        sum = matriz[fil, col] * 2;
                        matriz[fil+1, col] = sum;
                        matriz[fil, col] = 0;
                    }
                }
            }
            Desplazarcero(matriz);
        }

        public static void Desplazarcero(int[,] matriz)
        {
            int aux;
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
                for (int fil = 0; fil < matriz.GetLength(0)+1; fil++)
                {
                    if (matriz[fil, col] != 0 && matriz[fil - 1, col] == 0)
                    {
                        aux = matriz[fil, col];
                        matriz[fil, col] = matriz[matriz.GetLength(0) - 1, col];
                        matriz[matriz.GetLength(0) - 1, col] = aux;
                    }
                }
            }
        }
    }
}
