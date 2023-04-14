using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{

    public partial class Form1 : Form
    {
        int[,] matrizglobal = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 2, 2, 2, 2 } };
        Label[,] matrizlabel = new Label[4,4];

        public Form1()
        {
            InitializeComponent();
            matrizlabel[0, 0] = Casilla00;
            matrizlabel[0, 1] = Casilla01;
            matrizlabel[0, 2] = Casilla02;
            matrizlabel[0, 3] = Casilla03;
            matrizlabel[1, 0] = Casilla10;
            matrizlabel[1, 1] = Casilla11;
            matrizlabel[1, 2] = Casilla12;
            matrizlabel[1, 3] = Casilla13;
            matrizlabel[2, 0] = Casilla20;
            matrizlabel[2, 1] = Casilla21;
            matrizlabel[2, 2] = Casilla22;
            matrizlabel[2, 3] = Casilla23;
            matrizlabel[3, 0] = Casilla30;
            matrizlabel[3, 1] = Casilla31;
            matrizlabel[3, 2] = Casilla32;
            matrizlabel[3, 3] = Casilla33;

        }



        private void Casilla00_Click(object sender, EventArgs e)
        {
        }

        private void Casilla01_Click(object sender, EventArgs e)
        {
        }

        private void Casilla02_Click(object sender, EventArgs e)
        {
        }

        private void Casilla03_Click(object sender, EventArgs e)
        {
        }

        private void Casilla10_Click(object sender, EventArgs e)
        {
        }

        private void Casilla11_Click(object sender, EventArgs e)
        {
        }

        private void Casilla12_Click(object sender, EventArgs e)
        {
        }

        private void Casilla13_Click(object sender, EventArgs e)
        {
        }

        private void Casilla20_Click(object sender, EventArgs e)
        {
        }

        private void Casilla21_Click(object sender, EventArgs e)
        {
        }

        private void Casilla22_Click(object sender, EventArgs e)
        {
        }

        private void Casilla23_Click(object sender, EventArgs e)
        {
        }

        private void Casilla30_Click(object sender, EventArgs e)
        {
        }

        private void Casilla31_Click(object sender, EventArgs e)
        {
        }

        private void Casilla32_Click(object sender, EventArgs e)
        {
        }

        private void Casilla33_Click(object sender, EventArgs e)
        {
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            ordenarUp(matrizglobal);
            sumarUp(matrizglobal);
            generarNum2(matrizglobal);
            actualizarMatrizLabel(matrizglobal, matrizlabel);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            ordenarDown(matrizglobal);
            sumarDown(matrizglobal);
            generarNum2(matrizglobal);
            actualizarMatrizLabel(matrizglobal, matrizlabel);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            ordenarLeft(matrizglobal);
            sumarLeft(matrizglobal);
            generarNum2(matrizglobal);
            actualizarMatrizLabel(matrizglobal, matrizlabel);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            ordenarRight(matrizglobal);
            sumarRight(matrizglobal);
            generarNum2(matrizglobal);
            actualizarMatrizLabel(matrizglobal, matrizlabel);
        }
        public void ordenarDown(int[,] matrizglobal)
        {
            int aux;
            for (int col = 0; col < matrizglobal.GetLength(1); col++)
            {
                for (int fil = 1; fil < matrizglobal.GetLength(0); fil++)
                {
                    if (matrizglobal[fil, col] == 0 && matrizglobal[fil - 1, col] != 0)
                    {
                        while (fil != 0 && matrizglobal[fil - 1, col] != 0)
                        {
                            aux = matrizglobal[fil - 1, col];
                            matrizglobal[fil, col] = aux;
                            matrizglobal[fil - 1, col] = 0;
                            fil--;
                        }
                    }
                }
            }
        }
        public void sumarDown(int[,] matrizglobal)
        {
            int sum;
            for (int col = 0; col < matrizglobal.GetLength(1); col++)
            {
                for (int fil = 0; fil < matrizglobal.GetLength(0) - 1; fil++)
                {
                    if (matrizglobal[fil, col] == matrizglobal[fil + 1, col])
                    {
                        sum = matrizglobal[fil, col] * 2;
                        matrizglobal[fil + 1, col] = sum;
                        matrizglobal[fil, col] = 0;
                    }
                }
            }
            ordenarDown(matrizglobal);
        }

        public void ordenarUp(int[,] matrizglobal)
        {
            int aux;
            for (int col = 0; col < matrizglobal.GetLength(1); col++)
            {
                for (int fil = matrizglobal.GetLength(0) - 2; fil >= 0; fil--)
                {
                    if (matrizglobal[fil, col] == 0 && fil + 1 < matrizglobal.GetLength(0) && matrizglobal[fil + 1, col] != 0) //comprobar con traza pero funciona.
                    {
                        while (fil < matrizglobal.GetLength(0) - 1 && matrizglobal[fil + 1, col] != 0)
                        {
                            aux = matrizglobal[fil + 1, col];
                            matrizglobal[fil, col] = aux;
                            matrizglobal[fil + 1, col] = 0;
                            fil++;
                        }
                    }
                }
            }
        }
        public void sumarUp(int[,] matrizglobal)
        {
            int sum;
            for (int col = 0; col < matrizglobal.GetLength(1); col++)
            {
                for (int fil = 1; fil < matrizglobal.GetLength(0); fil++)
                {
                    if (matrizglobal[fil, col] == matrizglobal[fil - 1, col])
                    {
                        sum = matrizglobal[fil, col] * 2;
                        matrizglobal[fil - 1, col] = sum;
                        matrizglobal[fil, col] = 0;
                    }
                }
            }
            ordenarUp(matrizglobal);
        }
        public void ordenarRight(int[,] matrizglobal)
        {
            int aux;
            for (int fil = 0; fil < matrizglobal.GetLength(0); fil++)
            {
                for (int col = 1; col < matrizglobal.GetLength(1); col++)
                {
                    if (matrizglobal[fil, col] == 0 && matrizglobal[fil, col - 1] != 0)
                    {
                        while (col != 0 && matrizglobal[fil, col - 1] != 0)
                        {
                            aux = matrizglobal[fil, col - 1];
                            matrizglobal[fil, col] = aux;
                            matrizglobal[fil, col - 1] = 0;
                            col--;
                        }
                    }
                }
            }
        }
        public void sumarRight(int[,] matrizglobal)
        {
            int sum;
            for (int fil = 0; fil < matrizglobal.GetLength(0); fil++)
            {
                for (int col = 0; col < matrizglobal.GetLength(1) - 1; col++)
                {
                    if (matrizglobal[fil, col] == matrizglobal[fil, col + 1])
                    {
                        sum = matrizglobal[fil, col] * 2;
                        matrizglobal[fil, col + 1] = sum;
                        matrizglobal[fil, col] = 0;
                    }
                }
            }
            ordenarRight(matrizglobal);
        }
        public void ordenarLeft(int[,] matrizglobal)
        {
            int aux;
            for (int fil = 0; fil < matrizglobal.GetLength(0); fil++)
            {
                for (int col = matrizglobal.GetLength(1) - 2; col >= 0; col--)
                {
                    if (matrizglobal[fil, col] == 0 && col + 1 < matrizglobal.GetLength(1) && matrizglobal[fil, col + 1] != 0)
                    {
                        while (col < matrizglobal.GetLength(1) - 1 && matrizglobal[fil, col + 1] != 0)
                        {
                            aux = matrizglobal[fil, col + 1];
                            matrizglobal[fil, col] = aux;
                            matrizglobal[fil, col + 1] = 0;
                            col++;
                        }
                    }
                }
            }
        }
        public void sumarLeft(int[,] matrizglobal)
        {
            int sum;
            for (int fil = 0; fil < matrizglobal.GetLength(0); fil++)
            {
                for (int col = 1; col < matrizglobal.GetLength(1); col++)
                {
                    if (matrizglobal[fil, col] == matrizglobal[fil, col - 1])
                    {
                        sum = matrizglobal[fil, col] * 2;
                        matrizglobal[fil, col - 1] = sum;
                        matrizglobal[fil, col] = 0;
                    }
                }
            }
            ordenarLeft(matrizglobal);
        }

        public void actualizarMatrizLabel(int[,] matrizglobal, Label[,] matrizlabel)
        {
            for (int fil = 0; fil < matrizglobal.GetLength(0); fil++)
            {
                for (int col = 0; col < matrizglobal.GetLength(1); col++)
                {
                    if (matrizglobal[fil, col] != 0)
                    {
                        matrizlabel[fil, col].Text = Convert.ToString(matrizglobal[fil, col]);
                    }
                    else matrizlabel[fil, col].Text = "";
                }
            }
            for (int fil = 0; fil < matrizlabel.GetLength(0); fil++)
            {
                for (int col = 0; col < matrizlabel.GetLength(1); col++)
                {
                    if (matrizlabel[fil,col].Text=="2")
                    {
                        matrizlabel[fil, col].BackColor = Color.Red;
                    }
                    else if (matrizlabel[fil, col].Text == "4")
                    {
                        matrizlabel[fil, col].BackColor = Color.Orange;
                    }
                    else if (matrizlabel[fil, col].Text == "8")
                    {
                        matrizlabel[fil, col].BackColor = Color.Yellow;
                    }
                    else if (matrizlabel[fil, col].Text == "16")
                    {
                        matrizlabel[fil, col].BackColor = Color.Green;
                    }
                    else if (matrizlabel[fil, col].Text == "32")
                    {
                        matrizlabel[fil, col].BackColor = Color.Blue;
                    }
                    else if (matrizlabel[fil, col].Text == "64")
                    {
                        matrizlabel[fil, col].BackColor = Color.Purple;
                    }
                    else if (matrizlabel[fil, col].Text == "128")
                    {
                        matrizlabel[fil, col].BackColor = Color.Pink;
                    }
                    else if (matrizlabel[fil, col].Text == "256")
                    {
                        matrizlabel[fil, col].BackColor = Color.Brown;
                    }
                    else if (matrizlabel[fil, col].Text == "512")
                    {
                        matrizlabel[fil, col].BackColor = Color.Gray;
                    }
                    else if (matrizlabel[fil, col].Text == "1024")
                    {
                        matrizlabel[fil, col].BackColor = Color.Black;
                        matrizlabel[fil, col].ForeColor= Color.White;
                    }
                    else matrizlabel[fil, col].BackColor = Color.White;
                }
            }
        }

        public void generarNum2(int[,] matrizglobal)
        {
            int[] arrayceros = CrearArrayCeros(matrizglobal);
            Random random = new Random();
            int posicionAleatoria = random.Next(arrayceros.Length);
            int fila;
            int columna;
            fila = arrayceros[posicionAleatoria] / matrizglobal.GetLength(1);
            columna = arrayceros[posicionAleatoria] % matrizglobal.GetLength(1);
            matrizglobal[fila, columna] = 2;
        }

        public int[] CrearArrayCeros(int[,] matriz)
        {
            int contador = 0;

            for (int fil = 0; fil < matriz.GetLength(0); fil++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    if (matriz[fil, col] == 0)
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
            while (contador < array.Length)
            {
                fila = posicion / matriz.GetLength(1);
                columna = posicion % matriz.GetLength(1);
                if (matriz[fila, columna] == 0)
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
