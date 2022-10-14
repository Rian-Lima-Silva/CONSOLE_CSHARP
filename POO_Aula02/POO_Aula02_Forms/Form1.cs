using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Aula02_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Calcular calcular=new Calcular();
            calcular.numero1 = double.Parse(Num1.Text);
            calcular.numero2 = double.Parse(Num2.Text);
                     
            Resultado.Text = Convert.ToString(calcular.Soma(calcular.numero1,calcular.numero2));
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            Subtra subtracao=new Subtra();
            subtracao.numero1 = double.Parse(Num1.Text);
            subtracao.numero2 = double.Parse(Num2.Text);

            Resultado.Text = Convert.ToString(subtracao.Sub(subtracao.numero1, subtracao.numero2));

        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            Multiplicacao multiplicacao = new Multiplicacao();
            multiplicacao.numero1 = double.Parse(Num1.Text);
            multiplicacao.numero2 = double.Parse(Num2.Text);

            Resultado.Text = Convert.ToString(multiplicacao.Multi(multiplicacao.numero1, multiplicacao.numero2));
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            Divisao divisao = new Divisao();
            divisao.numero1 = double.Parse(Num1.Text);
            divisao.numero2 = double.Parse(Num2.Text);

            Resultado.Text = Convert.ToString(divisao.Div(divisao.numero1, divisao.numero2));
        }

        private void buttonSaida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
