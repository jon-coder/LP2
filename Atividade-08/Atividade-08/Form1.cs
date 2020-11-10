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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtividade1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex1"];

            if (fc != null)
                fc.Close();

            ex1 FrmEx1 = new ex1();
            FrmEx1.MdiParent = this;
            FrmEx1.WindowState = FormWindowState.Maximized;
            FrmEx1.Show();
        }

        private void btnAtividade2_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex2"];

            if (fc != null)
                fc.Close();

            ex2 FrmEx2 = new ex2();
            FrmEx2.MdiParent = this;
            FrmEx2.WindowState = FormWindowState.Maximized;
            FrmEx2.Show();
        }

        private void btnAtividade3_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex3"];

            if (fc != null)
                fc.Close();

            ex3 FrmEx3 = new ex3();
            FrmEx3.MdiParent = this;
            FrmEx3.WindowState = FormWindowState.Maximized;
            FrmEx3.Show();
        }

        private void btnAtividade4_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex4"];

            if (fc != null)
                fc.Close();

            ex4 FrmEx4 = new ex4();
            FrmEx4.MdiParent = this;
            FrmEx4.WindowState = FormWindowState.Maximized;
            FrmEx4.Show();
        }

        private void btnAtividade5_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex5"];

            if (fc != null)
                fc.Close();

            ex5 FrmEx5 = new ex5();
            FrmEx5.MdiParent = this;
            FrmEx5.WindowState = FormWindowState.Maximized;
            FrmEx5.Show();
        }

        private void btnAtividade6_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex6"];

            if (fc != null)
                fc.Close();

            ex6 FrmEx6 = new ex6();
            FrmEx6.MdiParent = this;
            FrmEx6.WindowState = FormWindowState.Maximized;
            FrmEx6.Show();
        }

        private void btnAtividade7_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ex7"];

            if (fc != null)
                fc.Close();

            ex7 FrmEx7 = new ex7();
            FrmEx7.MdiParent = this;
            FrmEx7.WindowState = FormWindowState.Maximized;
            FrmEx7.Show();
        }
    }
}
