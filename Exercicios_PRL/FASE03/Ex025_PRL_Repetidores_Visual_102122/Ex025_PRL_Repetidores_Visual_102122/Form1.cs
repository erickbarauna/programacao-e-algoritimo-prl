using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex025_PRL_Repetidores_Visual_102122
{
    public partial class Form1 : Form
    {
        int tamanho; // Variavel Inteira - Publica
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnquanto_Click(object sender, EventArgs e)
        {
            tamanho = int.Parse(txtTamanho.Text); // Entrada 1
            int contador = 1; // Variavel Inteira - Privada
            Lista.Items.Clear(); // Processo 1

            while (contador <= tamanho)
            {
                Lista.Items.Add(contador); // Saída 1
                contador++; // Processo 2
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            tamanho = int.Parse(txtTamanho.Text); // Entrada 1
            Lista.Items.Clear(); // Processo 1

            for (int i = 1; i <= tamanho; i++) // Laço 1 Para
            {
                Lista.Items.Add(i); // Saída 1 
            }
        }
    }
}
