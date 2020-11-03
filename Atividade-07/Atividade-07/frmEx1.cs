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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numEspacos = 0;
            for(int i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (rchtxtTexto.Text[i] == ' ')
                    numEspacos++;
            }
            MessageBox.Show($"Total Espaços em Branco: {numEspacos}");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int r = 0;
            foreach(char letra in rchtxtTexto.Text)
            {
                if (letra == 'R' || letra == 'r')
                    r++;
            }
            MessageBox.Show($"Total de Letras 'R': {r}");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int contador = 0; //contador de pares de letras.
            for(int i = 0; i < rchtxtTexto.Text.Length - 1; i++)
            {
                if (rchtxtTexto.Text[i] == rchtxtTexto.Text[i + 1])
                    contador++;
            }
            MessageBox.Show($"Total de Pares de Letras: {contador}");
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            rchtxtTexto.Clear();
        }
    }
}
