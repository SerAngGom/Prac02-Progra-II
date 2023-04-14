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
        int[,] matrizglobal = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 2, 2, 2, 2} };
        
        public Form1()
        {
            InitializeComponent();

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
            sumarUp(matrizglobal);
            actualizarMatrizLabel(matrizglobal);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            sumarDown(matrizglobal);
            actualizarMatrizLabel(matrizglobal);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            actualizarMatrizLabel(matrizglobal);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            sumarRight(matrizglobal);
            actualizarMatrizLabel(matrizglobal);
        }

        public void Generadorde2(int[,] matrizglobal)
        {
            Random random = new Random();
            int Posicion = random.Next(matrizglobal.Length);

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
            ordenarDown(matrizglobal);
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
                for (int fil = matrizglobal.GetLength(0)-2; fil >=0 ; fil--)
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
            ordenarUp(matrizglobal);
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
            ordenarRight(matrizglobal);
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

        }
        public void sumarLeft(int[,] matrizglobal)
        {

        }
        public void actualizarMatrizLabel(int[,] matrizglobal)
        {
            Casilla00.Text = Convert.ToString(matrizglobal[0, 0]);
            Casilla01.Text = Convert.ToString(matrizglobal[0, 1]);
            Casilla02.Text = Convert.ToString(matrizglobal[0, 2]);
            Casilla03.Text = Convert.ToString(matrizglobal[0, 3]);
            Casilla10.Text = Convert.ToString(matrizglobal[1, 0]);
            Casilla11.Text = Convert.ToString(matrizglobal[1, 1]);
            Casilla12.Text = Convert.ToString(matrizglobal[1, 2]);
            Casilla13.Text = Convert.ToString(matrizglobal[1, 3]);
            Casilla20.Text = Convert.ToString(matrizglobal[2, 0]);
            Casilla21.Text = Convert.ToString(matrizglobal[2, 1]);
            Casilla22.Text = Convert.ToString(matrizglobal[2, 2]);
            Casilla23.Text = Convert.ToString(matrizglobal[2, 3]);
            Casilla30.Text = Convert.ToString(matrizglobal[3, 0]);
            Casilla31.Text = Convert.ToString(matrizglobal[3, 1]);
            Casilla32.Text = Convert.ToString(matrizglobal[3, 2]);
            Casilla33.Text = Convert.ToString(matrizglobal[3, 3]);
        }
    }
}
