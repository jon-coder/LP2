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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmEx1"];

            if(fc != null)
                fc.Close();            

            frmEx1 FrmEx1 = new frmEx1();
            FrmEx1.MdiParent = this;
            FrmEx1.WindowState = FormWindowState.Maximized;
            FrmEx1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmEx2"];

            if (fc != null)
                fc.Close();

            frmEx2 FrmEx2 = new frmEx2();
            FrmEx2.MdiParent = this;
            FrmEx2.WindowState = FormWindowState.Maximized;
            FrmEx2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmEx3"];

            if (fc != null)
                fc.Close();

            frmEx3 FrmEx3 = new frmEx3();
            FrmEx3.MdiParent = this;
            FrmEx3.WindowState = FormWindowState.Maximized;
            FrmEx3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmEx4"];

            if (fc != null)
                fc.Close();

            frmEx4 FrmEx4 = new frmEx4();
            FrmEx4.MdiParent = this;
            FrmEx4.WindowState = FormWindowState.Maximized;
            FrmEx4.Show();
        }
    }
}
