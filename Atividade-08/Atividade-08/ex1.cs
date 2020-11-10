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
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0, max = 20;
            double[] vetor = new double[max];
            string texto = "";            

            while (i < max)
            {
                if (Double.TryParse((Interaction.InputBox($"Informe o valor da posição {i + 1}", "Entrada de dados")),
                    out vetor[i]))
                {
                    i++;
                }
                else
                {
                    MessageBox.Show("INFORME UM VALOR VÁLIDO!");
                    continue;
                }
            }while (i < max);

            for(i=max-1; i >= 0; i--)
            {
                texto += vetor[i] + " ";
            }

            MessageBox.Show($"{texto}");
        }
    }
}
