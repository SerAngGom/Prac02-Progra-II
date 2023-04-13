using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { { 8, 0, 4, 4, 0, 2 }, { 4, 16, 0, 2, 0, 2 }, { 0, 0, 0, 8, 2, 0 } };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] arrayceros = CrearArrayCeros(matriz);
            Random random= new Random();
            int posicionAleatoria = random.Next(arrayceros.Length);
            Console.WriteLine(arrayceros[posicionAleatoria]);
            int fila;
            int columna;
            fila = arrayceros[posicionAleatoria] / matriz.GetLength(1);
            columna = arrayceros[posicionAleatoria] % matriz.GetLength(1);
            Console.WriteLine("("+ fila + "," + columna + ")");
            Console.ReadKey();
        }

        public static int[] CrearArrayCeros(int[,] matriz)
        {
            int contador = 0;
            
            for (int fil = 0; fil < matriz.GetLength(0); fil++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if (matriz[fil,col]==0)
                    {
                        contador++;
                    }
                }
                
            }
            int[] array = new int[contador];
            contador = 0;
            int posicion = 0;
            int fila;
            int columna;
            while (contador< array.Length)
            {
                fila = posicion/matriz.GetLength(1);
                columna = posicion % matriz.GetLength(1);
                if (matriz[fila,columna]==0)
                {
                    array[contador] = posicion;
                    contador++;
                }
                posicion++;
            }
            return array;

        }
    }
}