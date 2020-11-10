using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_08
{
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            int max = 16;
            int[] tamanho = new int[max];
            string[] nomes = new string[max];

            for (int i = 0; i < max; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o {i + 1}º  nome completo:", "Lista de Nomes");
            } 

            for (int i = 0; i < max; i++)
            {
                foreach (char letra in nomes[i])
                    tamanho[i]++;
            }

            for (int i = 0; i < max; i++)
                rchTxtSaida.AppendText($"{nomes[i]} tem {tamanho[i]} caracteres\n");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rchTxtSaida.Clear();
        }
    }
}
