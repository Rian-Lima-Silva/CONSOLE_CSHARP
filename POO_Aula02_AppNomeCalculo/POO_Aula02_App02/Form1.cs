using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Aula02_App02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Soma s = new Soma();
            Usuario name = new Usuario();
            name.nome = Usuario.Text;
            s.numero1 = double.Parse(num1.Text);
            s.numero2 = double.Parse(num2.Text);
            Resultado.Text= name.Nome(Convert.ToString(s.Adicao(s.numero1,s.numero2)));
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            Subtracao s = new Subtracao();
            Usuario name = new Usuario();
            name.nome = Usuario.Text;
            s.numero1 = double.Parse(num1.Text);
            s.numero2 = double.Parse(num2.Text);
            Resultado.Text = name.Nome(Convert.ToString(s.Sub(s.numero1, s.numero2)));

        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            Multiplicacao s = new Multiplicacao();
            Usuario name = new Usuario();
            name.nome = Usuario.Text;
            s.numero1 = double.Parse(num1.Text);
            s.numero2 = double.Parse(num2.Text);
            Resultado.Text = name.Nome(Convert.ToString(s.Multi(s.numero1, s.numero2)));
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            Divisao s = new Divisao();
            Usuario name = new Usuario();
            name.nome = Usuario.Text;
            s.numero1 = double.Parse(num1.Text);
            s.numero2 = double.Parse(num2.Text);
            Resultado.Text = name.Nome(Convert.ToString(s.Div(s.numero1, s.numero2)));
        }

        private void buttonSaida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
