using System;
using System.Windows.Forms;

namespace Atividade_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ladoA, ladoB, ladoC;        

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if(txtLadoA.Text == "" || txtLadoB.Text == "" || txtLadoC.Text == "")
            {
                MessageBox.Show("Informe todos os valores!");
            }
            else
            {
                if(double.TryParse(txtLadoA.Text, out ladoA) && 
                   (double.TryParse(txtLadoB.Text, out ladoB)) &&
                    (double.TryParse(txtLadoC.Text, out ladoC)))
                {
                    double ladoMaior = MaiorLado(ladoA, ladoB, ladoC);
                    if(ladoMaior < (ladoA + ladoB + ladoC - ladoMaior))
                    {
                        if (ladoA == ladoB && ladoB == ladoC)
                        {
                            MessageBox.Show("Triângulo Equilátero");
                        }
                        else
                        {
                            if(ladoA == ladoB || ladoB == ladoC)
                            {
                                MessageBox.Show("Triângulo Isósceles");
                            }
                            else
                            {
                                MessageBox.Show("Triângulo Escaleno");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Figura não pode ser um triângulo!");
                    }
                }
                else
                {
                    MessageBox.Show("Informe valores válidos!");
                }
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }

        private double MaiorLado (double lado1, double lado2, double lado3)
        {
            return lado1 > lado2 && lado1 > lado3 ? lado1 : lado2 > lado3 ? lado2 : lado3;
        }        
    }
}
