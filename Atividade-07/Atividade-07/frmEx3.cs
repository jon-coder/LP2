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
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            txtPalavra.Text.ToUpper();
            txtPalavra.Text.Replace(" ", "");

            string versaoInversa = "";
            char[] auxiliar = txtPalavra.Text.ToCharArray();
            Array.Reverse(auxiliar);
            foreach (char c in auxiliar)
                versaoInversa += c;
            
            if(string.Compare(txtPalavra.Text, versaoInversa, true) == 0)
                MessageBox.Show("É PALÍNDROMO!");
            else
                MessageBox.Show("NÃO É PALÍNDROMO");

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtPalavra.Clear();
        }
    }
}
