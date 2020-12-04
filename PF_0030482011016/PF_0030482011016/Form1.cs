using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PF_0030482011016
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Abre a conexao com o servidor
                conexao = new SqlConnection(
                    "Data Source=DESKTOP-DN55LER\\SQLEXPRESS;Initial Catalog=LP_2;Integrated Security=True"
                );
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Banco de Dados" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros" + ex.Message);
            }
        }

        private void cadastroDeCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];
            if (fc != null)
                fc.Close();

            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmS = new frmSobre();
            frmS.MdiParent = this;
            frmS.Show();
        }
    }
}
