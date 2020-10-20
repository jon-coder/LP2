using System;
using System.Windows.Forms;

namespace Atividade_06_07
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnTesteIgualdade_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
                MessageBox.Show("São Iguais!");
            else
                MessageBox.Show("São Diferentes!");
        }

        private void btnInsere1_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text
                + txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio);
        }

        private void btnInsere2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
