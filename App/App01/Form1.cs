using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Numero1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TEXT1
            double numero1;
            
            numero1 = double.Parse(textBox1.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Numero2
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TEXTE2
            double numero2;
            
            numero2 = double.Parse(textBox2.Text);
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //SOMA
            double numero1, numero2;
            double resultado;

            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);
            resultado = numero1 + numero2;

            label4.Text = resultado.ToString();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DIVIDIR

            double numero1, numero2;
            double resultado;

            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);
            resultado = numero1 / numero2;

            label4.Text =resultado.ToString();

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            //MULTIPLCAR
            double numero1, numero2;
            double resultado;

            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);

            resultado = numero1 * numero2;

            label4.Text = resultado.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SUBTRAIR
            double numero1, numero2;
            double resultado;

            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);

            resultado = numero1 - numero2;

            label4.Text = resultado.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {
          //Resultado   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
