using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex026_PRL_Repetidores_VIsual_102322
{
    public partial class Form1 : Form
    {
        int Tamanho;  //Variavel Inteira - Pública
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPara_Click(object sender, EventArgs e)
        {
            int NumPar = 0; // Variavel inteira - Saída
            int NumImpar = 1; // Variavel inteira - Saída

            Tamanho = int.Parse(txtTamanho.Text); // Entrada 1

            for (int c = 0; c < Tamanho; c++) // Laço 1 - Para
            {
                ListaPar.Items.Add(NumPar); // Saída 1
                ListaImpar.Items.Add(NumImpar); // Saída 2
                NumPar += 2; // Processo 1
                NumImpar += 2; // Processo 2
            }
        }

        private void BtnEnquanto_Click(object sender, EventArgs e)
        {
            int NumPar = 0; // Variavel inteira - Saída
            int NumImpar = 1; // Variavel inteira - Saída
            int count = 0; // Variavel inteira

            Tamanho = int.Parse(txtTamanho.Text); // Entrada 1

            while (count < Tamanho)
            {
                ListaPar.Items.Add(NumPar); // Saída 1
                ListaImpar.Items.Add(NumImpar); // Saída 2
                NumPar += 2; // Processo 1
                NumImpar += 2; // Processo 2
                count++; // Processo 3
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            ListaPar.Items.Clear(); // Processo 2
            ListaImpar.Items.Clear(); // Processo 1
        }
    }
}
