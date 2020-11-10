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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int q = 0, max = 10;
            int[] qtde = new int[max];
            double[] preco = new double[max];
            double faturamento = 0;

            while (q < max)
            {
                if (Int32.TryParse((Interaction.InputBox($"Informe o quantidade do produto {q + 1}", "Entrada de dados")),
                    out qtde[q]))
                {
                    q++;
                }
                else
                {
                    MessageBox.Show("INFORME UM VALOR VÁLIDO!");
                    continue;
                }
            } while (q < max);

            q = 0; 

            while (q < max)
            {
                if (Double.TryParse((Interaction.InputBox($"Informe o preço do produto {q + 1}", "Entrada de dados")),
                    out preco[q]))
                {
                    q++;
                }
                else
                {
                    MessageBox.Show("INFORME UM VALOR VÁLIDO!");
                    continue;
                }
            } while (q < max) ;

            for (q = 0; q < max; q++)
                faturamento += qtde[q] * preco[q];

            MessageBox.Show($"O faturamento total é de: R$ " + faturamento.ToString("F2"));
        }
    }
}
