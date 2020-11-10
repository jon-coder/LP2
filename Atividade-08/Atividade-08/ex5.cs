using System;
using System.Collections;
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
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();

            //Valores de Entrada
            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Janete");
            lista.Add("Otávio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Thais");

            lista.Remove("Otávio");

            foreach(var nome in lista)
                MessageBox.Show($"{nome}");               
        }
    }
}
