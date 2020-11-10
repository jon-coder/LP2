using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_08
{
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
            "Leonardo", "Jose", "Nelma", "Tobby"};

            Int32 i, total = 0;
            Int32 n = Alunos.Length;

            for (i = 0; i < n - 1; i++)
                total += Alunos[i].Length;

            MessageBox.Show($"TOTAL = {total}");
        }
    }
}
