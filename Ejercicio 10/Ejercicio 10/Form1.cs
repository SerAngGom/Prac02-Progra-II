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
        int[,] matrizglobal = { { 2, 0, 0, 0 }, { 2, 0, 0, 0 }, { 2, 0, 0, 0 }, { 2, 0, 0, 0 } };
        
        public Form1()
        {
            InitializeComponent();

        }


        private void Casilla00_Click(object sender, EventArgs e)
        {
            Casilla00.Text= Convert.ToString(matrizglobal[0, 0]);
        }

        private void Casilla01_Click(object sender, EventArgs e)
        {
            Casilla01.Text = Convert.ToString(matrizglobal[0, 1]);
        }

        private void Casilla02_Click(object sender, EventArgs e)
        {
            Casilla02.Text = Convert.ToString(matrizglobal[0, 2]);
        }

        private void Casilla03_Click(object sender, EventArgs e)
        {
            Casilla03.Text = Convert.ToString(matrizglobal[0, 3]);
        }

        private void Casilla10_Click(object sender, EventArgs e)
        {
            Casilla10.Text = Convert.ToString(matrizglobal[1, 0]);
        }

        private void Casilla11_Click(object sender, EventArgs e)
        {
            Casilla11.Text = Convert.ToString(matrizglobal[1, 1]);
        }

        private void Casilla12_Click(object sender, EventArgs e)
        {
            Casilla12.Text = Convert.ToString(matrizglobal[1, 2]);
        }

        private void Casilla13_Click(object sender, EventArgs e)
        {
            Casilla13.Text = Convert.ToString(matrizglobal[1, 3]);
        }

        private void Casilla20_Click(object sender, EventArgs e)
        {
            Casilla20.Text = Convert.ToString(matrizglobal[2, 0]);
        }

        private void Casilla21_Click(object sender, EventArgs e)
        {
            Casilla21.Text = Convert.ToString(matrizglobal[2, 1]);
        }

        private void Casilla22_Click(object sender, EventArgs e)
        {
            Casilla22.Text = Convert.ToString(matrizglobal[2, 2]);
        }

        private void Casilla23_Click(object sender, EventArgs e)
        {
            Casilla23.Text = Convert.ToString(matrizglobal[2, 3]);
        }

        private void Casilla30_Click(object sender, EventArgs e)
        {
            Casilla30.Text = Convert.ToString(matrizglobal[3, 0]);
        }

        private void Casilla31_Click(object sender, EventArgs e)
        {
            Casilla31.Text = Convert.ToString(matrizglobal[3, 1]);
        }

        private void Casilla32_Click(object sender, EventArgs e)
        {
            Casilla32.Text = Convert.ToString(matrizglobal[3, 2]);
        }

        private void Casilla33_Click(object sender, EventArgs e)
        {
            Casilla33.Text = Convert.ToString(matrizglobal[3, 3]);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            
            sumarDown(matrizglobal);
            sumarDown(matrizglobal);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {

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

        }
    }
}
