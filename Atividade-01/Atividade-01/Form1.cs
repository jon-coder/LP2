using System;
using System.Windows.Forms;

namespace Atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;

            if (double.TryParse(txtAltura.Text, out altura) && 
                (double.TryParse(txtRaio.Text, out raio)))
            {
                double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtVolume.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtAltura.Clear();
            txtVolume.Clear();
            txtRaio.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
