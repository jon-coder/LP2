using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_07
{
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   if(txtNome.Text != "" && txtInscricao.Text != "" && txtCargo.Text != "")
            {
                double salario, gratificacao;
                int producao;

                if ((double.TryParse(txtSalario.Text, out salario)) &&
                    (double.TryParse(txtGratificacao.Text, out gratificacao)) &&
                    (int.TryParse(txtProducao.Text, out producao)))
                {
                    int b = 0, c = 0, d = 0;
                    double salarioBruto;

                    //TESTE DE NÍVEIS
                    if(producao >= 100)
                    {
                        b = 1;
                        if(producao >= 120)
                        {
                            c = 1;
                            if(producao >= 150)
                            {
                                d = 1;
                            }
                        }
                    }

                    //CÁLCULO SALÁRIO BRUTO
                    salarioBruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                    //RESTRIÇÕES
                    if(salarioBruto >= 7000)
                    {
                        if (d != 0 && gratificacao > 0)
                            txtSalarioBruto.Text = salarioBruto.ToString("F2");
                        else
                            salarioBruto = 7000;
                    }
                    txtSalarioBruto.Text = salarioBruto.ToString("F2");
                }

                else
                {
                    MessageBox.Show("Informe valores VÁLIDOS!");
                }
            }
            else
            {
                MessageBox.Show("Informe TODOS os campos!");
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtInscricao.Clear();
            txtCargo.Clear();
            txtProducao.Clear();
            txtSalario.Clear();
            txtGratificacao.Clear();
            txtSalarioBruto.Clear();
        }
    }
}
