using System;
using System.Windows.Forms;

namespace Atividade_06_07
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            if(int.TryParse(txtNum1.Text, out valor1) && 
                int.TryParse(txtNum2.Text, out valor2))
            {
                Random rnd = new Random();
                double r = rnd.Next(valor1, valor2);
                MessageBox.Show($"VALOR SORTEADO: {r}");
            }
            else
            {
                MessageBox.Show("Informe um valor numérico inteiro!");
            }

        }
    }
}
