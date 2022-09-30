using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2_Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text.Box1
            double n1;


        }//textBox1

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //text.Box2
            double n2;


        }//textBox2

        private void button1_Click(object sender, EventArgs e)//BOTÃO DE SOMA
        {
            

            double n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);


            label1.Text = Convert.ToString(Soma(n1, n2));
        }

        private void button2_Click(object sender, EventArgs e)//BOTÃO SUBTRAÇÃO
        {
            double n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            label1.Text = Convert.ToString(Soma(n1, n2));


        }

        private void button3_Click(object sender, EventArgs e)//BOTÃO MULTIPLICAÇÃO
        {
            double n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            label1.Text = Convert.ToString(Multiplicacao(n1, n2));

        }
        private void button4_Click(object sender, EventArgs e)//BOTÃO DIVISÃO
        {
            double n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            label1.Text = Convert.ToString(Divisao(n1, n2));
        }

        private double Soma(double n1, double n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;

        } //FUNÇÃO SOMA
        private double Subtracao(double n1, double n2)
        {
            double resultado;
            resultado = n1 - n2;
            return resultado;

        } //FUNÇÃO SUBTRAÇÃO
        private double Multiplicacao(double n1, double n2)
        {
            double resultado;
            resultado = n1 * n2;
            return resultado;

        } //FUNÇÃO MULTIPLICAÇÃO
        private double Divisao(double n1, double n2)
        {
            double resultado;
            resultado = n1 / n2;
            return resultado;

        } //FUNÇÃO DIVISÃO

       
    }
}
