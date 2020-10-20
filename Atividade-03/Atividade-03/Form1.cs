using System;
using System.Windows.Forms;

namespace Atividade_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbxFem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxFem.Checked == true)
                ckbxMasc.CheckState = CheckState.Unchecked;
        }        

        private void ckbxMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxMasc.Checked == true)
                ckbxFem.CheckState = CheckState.Unchecked;
        }

        double altura, pesoAtual, pesoIdeal;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if ((double.TryParse(mskbxAltura.Text, out altura)) && 
                (double.TryParse(mskbxPesoAtual.Text, out pesoAtual)))
            {
                if (ckbxMasc.Checked)
                {                    
                    pesoIdeal = Math.Round((72.7 * altura - 58), 2);                    
                }
                else
                {
                    if (ckbxFem.Checked)
                    {
                        pesoIdeal = Math.Round((62.1 * altura - 44.7), 2);                        
                    }
                    else
                    {
                        MessageBox.Show("Selecione um gênero");
                        return;
                    }                   
                }                
                
                if (pesoAtual > pesoIdeal)
                {
                    MessageBox.Show("Você está acima do peso ideal. Procure um especialista!");
                }
                else
                {
                    if(pesoAtual == pesoIdeal)
                    {
                        MessageBox.Show("Você está com seu peso ideal no limite. Mantenha-se atento!");
                    }
                    else
                    {
                        MessageBox.Show("Seu peso está abaixo do peso ideal. Parabéns!");
                    }
                }

                txtPesoIdeal.Text = pesoIdeal.ToString();
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesoIdeal.Clear();
            mskbxAltura.Clear();
            mskbxPesoAtual.Clear();
            altura = 0.0;
            pesoAtual = 0.0;
            pesoIdeal = 0.0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
