using System;
using System.Windows.Forms;

namespace Atividade_06_07
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContarNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i < rchTexto.Text.Length; i++)
            {
                if (char.IsNumber(rchTexto.Text[i]))
                    contador++;               
            }
            MessageBox.Show($"Quantidade de números: {contador}");
        }

        private void btnPosicaoBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            while(contador < rchTexto.Text.Length)
            {
                if(char.IsWhiteSpace(rchTexto.Text[contador]))
                    MessageBox.Show($"Espaço branco na posição {contador}");
                contador++;
            }
        }

        private void btnContarLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;            
            foreach(char c in rchTexto.Text)
            {
                if (Char.IsLetter(c))
                    contador++;
            }
            MessageBox.Show($"Total de Letras: {contador}");

        }
    }
}
