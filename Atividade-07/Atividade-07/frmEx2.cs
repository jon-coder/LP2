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
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void btnGerarValor_Click(object sender, EventArgs e)
        {
            double numH = 0;
            if(Double.TryParse(txtValorEntrada.Text, out Double valorEntrada) &&
                txtValorEntrada.Text != "0")
            {
                for (int i = 1; i <= valorEntrada; i++)
                    numH += (1.0 / i);

                MessageBox.Show("Valor Final de H = " + numH.ToString("F2"));
            }
            else
                MessageBox.Show("Informe um valor válido!");
        }
    }
}
