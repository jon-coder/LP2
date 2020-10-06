using System;
using System.Windows.Forms;

namespace Atividade_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarDescontos_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mskbxSalarioBruto.Text == "")
            {
                MessageBox.Show("ALERT: Informe todos os campos!");
                return;
            }

            double salarioBruto, aliquotaInss, aliquotaIrpf, salarioFamilia, salarioLiquido = 0;
            if((double.TryParse(mskbxSalarioBruto.Text, out salarioBruto)))
            {
                salarioBruto = Convert.ToDouble(mskbxSalarioBruto.Text);
            }
            else
            {
                MessageBox.Show("ALERT: Informe um valor válido no campo Salário Bruto!");
                return;
            }            

            // Cálculo Alíquota INSS
            if (salarioBruto < 800.48)
            {
                txtAliquotaInss.Text = "7,65 %";
                aliquotaInss = salarioBruto * 0.0765;
            }
            else
            {
                if(salarioBruto < 1050.01)
                {
                    txtAliquotaInss.Text = "8,65 %";
                    aliquotaInss = salarioBruto * 0.0865;
                }
                else
                {
                    if(salarioBruto < 1400.78)
                    {
                        txtAliquotaInss.Text = "9,00 %";
                        aliquotaInss = salarioBruto * 0.09;
                    }
                    else
                    {
                        if(salarioBruto < 2801.57)
                        {
                            txtAliquotaInss.Text = "11,00 %";
                            aliquotaInss = salarioBruto * 0.11;
                        }
                        else
                        {
                            txtAliquotaInss.Text = "Valor Teto!";
                            aliquotaInss = 308.17;
                        }
                    }
                }
            }
            txtDescontoInss.Text = aliquotaInss.ToString("N2");

            // Cálculo Alíquota IRPF
            if(salarioBruto < 1257.13)
            {
                txtAliquotaIrpf.Text = "Isento";
                aliquotaIrpf = 0.00;
            }
            else
            {
                if(salarioBruto < 2512.09)
                {
                    txtAliquotaIrpf.Text = "15,00 %";
                    aliquotaIrpf = salarioBruto * 0.15;
                }
                else
                {
                    txtAliquotaIrpf.Text = "27,50 %";
                    aliquotaIrpf = salarioBruto * 0.275;
                }
            }
            txtDescontoIrpf.Text = aliquotaIrpf.ToString("N2");

            //Cálculo Salário Família
            byte numeroFilhos = (byte)numNumeroDeFilhos.Value;
            if(salarioBruto < 435.53)
            {
                salarioFamilia = 22.33 * numeroFilhos;            
            }
            else
            {
                if(salarioBruto < 654.62)
                {
                    salarioFamilia = 15.74 * numeroFilhos;
                }
                else
                {
                    salarioFamilia = 0.00;
                }
            }
            txtSalarioFamilia.Text = salarioFamilia.ToString("N2");

            // Cálculo Salário Líquido
            salarioLiquido = salarioBruto - aliquotaInss - aliquotaIrpf + salarioFamilia;
            txtSalarioLiquido.Text = salarioLiquido.ToString("N2");

            //Mensagem Resumo
            string pronome, estadoCivil;
            if(rbtnMasc.Checked == true)
            {
                pronome = "Sr.";
            }
            else
            {
                pronome = "Sra.";
            }

            if(ckbxCasado.CheckState == CheckState.Checked)
            {
                estadoCivil = "Casado(a)";
            }
            else
            {
                estadoCivil = "Solteiro(a)";
            }

            rtxtSituacao.Text = $"Situação do(a) {pronome} {txtNome.Text}, " +
                $"cujo estado civil é {estadoCivil} e possui {numeroFilhos} filho(s).";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskbxSalarioBruto.Clear();
            numNumeroDeFilhos.Value = 0;
            ckbxCasado.CheckState = CheckState.Unchecked;
            rbtnFem.Checked = true;
            rbtnMasc.Checked = false;
            txtAliquotaInss.Clear();
            txtAliquotaIrpf.Clear();
            txtDescontoInss.Clear();
            txtDescontoIrpf.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
            rtxtSituacao.Clear();                     
        }
    }
}
