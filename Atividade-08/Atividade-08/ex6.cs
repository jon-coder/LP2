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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            int maxAlunos = 20, col = 3;
            double media = 0.0;
            string[,] matriz = new string[maxAlunos, col];
            string infoSaida = "";

            for(int i = 0; i < maxAlunos; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if(Double.TryParse((Interaction.InputBox($"Digite a nota {j+1} do aluno {i+1}", "Nota:")), out double nota))
                    {
                        if(nota >=0 && nota <= 10)
                        {
                            matriz[i, j] = nota.ToString("F2");                            
                        }
                        else
                        {
                            MessageBox.Show("Informe uma nota válida!");
                            return;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Informe um valor numérico!");
                        return;
                    }                    
                }                
            }
            
            for (int i = 0; i < maxAlunos; i++)
            {                
                media = ((Convert.ToDouble(matriz[i, 0])) +
                    (Convert.ToDouble(matriz[i, 1])) +
                    (Convert.ToDouble(matriz[i, 2]))) / 3.0;

                infoSaida += $"Aluno {i} - Média " + media.ToString("F2") + "\n";
            }
            MessageBox.Show($"MÉDIA DOS ALUNOS\n\n{infoSaida}");
        }
    }
}
