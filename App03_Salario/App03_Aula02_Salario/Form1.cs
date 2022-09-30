namespace App03_Aula02_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//textBox1
        {
            double salario;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//textBox2
        {
            double aumento;
        }

        private void button1_Click(object sender, EventArgs e)//BOTÃO DE CALCULAR
        {
            double salario, aumento;
            salario = double.Parse(textBox1.Text);
            aumento = double.Parse(textBox2.Text);
            

            label4.Text = Convert.ToString("R$"+Calcular(salario,aumento));
               
        }

        private double Calcular(double salario, double aumento)//Função de calculo
        {
            aumento = aumento / 100;

            if (salario > 1200)
            {
                return  salario = salario + (salario * aumento);
            }
            else
            {
                return salario = salario - (salario * aumento);
            }
                      
        }

        private void button2_Click(object sender, EventArgs e)//BOTÃO DE SAIDA
        {
            Close();
        }
    }
}