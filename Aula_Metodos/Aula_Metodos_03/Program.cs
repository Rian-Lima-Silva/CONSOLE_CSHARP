using System;

namespace Aula06_Metodos_03//COM Parametros + TIPO:Função(tipo primitivo [string,int,double])
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            //1º - LOGIN
            string nome, senha,usuario="";
            string limpa = "";
            do
            {
                Console.WriteLine("1º - Faça Login");
                Console.WriteLine("Digite o seu USUARIO:");
                usuario = Console.ReadLine();
                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a sua senha:");
                senha = Console.ReadLine();
                Console.WriteLine(Log(nome, senha));

                Console.WriteLine("Voce deseja continuar? s/n");
                limpa = Console.ReadLine();
                Console.Clear();
            } while (limpa == "n");
            

            //2º - SOMA DE 2 NUMEROS
            double n1, n2;

            Console.WriteLine("2º - Soma de 2 Números");
            Console.WriteLine("Digite o 1º número:");
            n1 =double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado de {0}+{1}={2}",n1,n2,Soma(n1,n2));

            Console.WriteLine("Voce deseja continuar? s/n");
            limpa = Console.ReadLine();
            limpar(limpa);

            /*3º - CRIE UMA FUNÇÃO QUE SOLICITE ALGUMAS NOTAS E REOTRNE SE ELE É APROVADO OU REPROVADO, 
             A SUA MÉDIA DE APROVAÇÃO É 5*/

            int nota1, nota2;

            Console.WriteLine("3º - Calcule a média");
            Console.WriteLine("Digite a 1º nota de 1/10");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2º nota de 1/10:");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você foi: {0}",Media(nota1, nota2));

            Console.WriteLine("{0},Obrigado por sua Cooperação",usuario);

        }

        public static string Log(string nome, string senha)
        {
            string nomeCad = "Rian";
            string senhaCad = "123";


            if (nome == nomeCad && senha == senhaCad)
            {
                return "VOCÊ ESTÁ CONECTADO!";
            }
            else
            {
                return "NOME OU SENHA INCORRETOS";
            }
        }

        public static double Soma(double n1,double n2)
        {
            double res;
            res = n1+n2;
            return res;
        }

        public static string Media(int nota1,int nota2)
        {
            int media;
            media = nota1 + nota2;
            media = media / 2;

            if (nota1 > 10 || nota2 > 10)
            {
                return "SUA 1º OU 2º NOTA ESTÁ ERRADA!";
               
            }

            if (media >= 5)
            {
                return "Aprovado";

            }
            else
            {
                return "Reprovado";
            }
        }

        public static void limpar(string limpa)
        {
            string limpeza ="s";

            if (limpa==limpeza)
            {
                Console.Clear();
            }
            else
            {
                limpa = "n";
            }
        }

        



    }
}
