using System;
using System.Windows.Forms;

namespace Atividade_02
{
    public partial class Form1 : Form
    {
        double valorEmMemoria = 0;
        string operadorEmAcao = "";        
        bool testeOperador = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada(object sender, EventArgs e)
        {
            if(txtVisor.Text == "0" || testeOperador)
            {
                txtVisor.Clear();
            }

            testeOperador = false;
            Button button = (Button)sender;

            if(button.Text == ",")
            {
                if (!txtVisor.Text.Contains(","))
                {
                    txtVisor.Text += button.Text;
                }
            }

            else
            {
                txtVisor.Text += button.Text;
            }
        }
        private void btnOperador(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(valorEmMemoria != 0)
            {
                btnEqual.PerformClick();
                valorEmMemoria = double.Parse(txtVisor.Text);
                lblMemoria.Text = valorEmMemoria + " " + operadorEmAcao;
                testeOperador = true;
            }
            else
            {
                operadorEmAcao = button.Text;
                valorEmMemoria = double.Parse(txtVisor.Text);
                lblMemoria.Text = valorEmMemoria + " " + operadorEmAcao;
                testeOperador = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operadorEmAcao)
            {
                case "+":
                    txtVisor.Text = (valorEmMemoria + double.Parse(txtVisor.Text)).ToString();
                    break;

                case "-":
                    txtVisor.Text = (valorEmMemoria - double.Parse(txtVisor.Text)).ToString();
                    break;

                case "x":
                    txtVisor.Text = (valorEmMemoria * double.Parse(txtVisor.Text)).ToString();
                    break;

                case "/":
                    txtVisor.Text = (valorEmMemoria / double.Parse(txtVisor.Text)).ToString();
                    break;

                default:
                    break;
            }

            if (txtVisor.Text == "∞")
            { 
                txtVisor.Text = "ERRO!";
                lblMemoria.Text = "";
            }
            else
            {
                valorEmMemoria = double.Parse(txtVisor.Text);
                lblMemoria.Text = "";
            }     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            lblMemoria.Text = "";
            valorEmMemoria = 0;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
