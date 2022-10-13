using System;


namespace Aula08_LOGIN_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno;
            string[,] T = new string[2, 2];
            string nome, senha;
            char menu;

            //Mensagem de Bem Vindo
            Console.WriteLine("\nSEJA BEM-VINDO AO PROGRAMA: AULA 08 - lOGIN");
            Console.Write("tecle enter para continuar");
            retorno = Console.ReadLine();


            //Tela de Login
                inicio:
                Console.Clear();
                Console.WriteLine("TELA DE LOGIN\n");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Login");
                Console.WriteLine("Selecione a opção acima:");
                menu = char.Parse(Console.ReadLine());

                switch (menu)
                {
                    case '1':
                        Cadastro(T);
                    Console.Write("tecle enter para continuar");
                    retorno = Console.ReadLine();
                    goto inicio;
                       
                    case '2':
                    
                    Console.WriteLine(Login(T));
                    Console.Write("tecle enter para continuar");
                    retorno = Console.ReadLine();
                    break;
                    
                } 
            

        //Menu de Opções
        
            Console.Clear();
            Console.WriteLine("TELA DE LOGIN\n");
            Console.WriteLine("1 - Cadastrar 10 pessoas");
            Console.WriteLine("2 - Cadastrar 10 notas");
            Console.WriteLine("3 - Contagem de 0 ate 100 numeros pares");
            Console.WriteLine("Selecione a opção acima:");
            menu = char.Parse(Console.ReadLine());

            switch (menu)
            {
                case '1':
                    Console.Clear();
                    Nomes();
                    break;
                case '2':
                    Console.Clear();
                    Notas();
                    break;
                case '3':
                    Console.Clear();
                    Contagem();
                    break;
            }

        }

        static string[,] Cadastro(string[,] T)
        {
            string nomeCad, senhaCad, final;


            for (int i = 0; i < 4; i++)
            {
                for (int c = 0; c < 2; c++)
                {

                    Console.WriteLine("Cadastre NOME:");
                    T[i, c] = nomeCad = Console.ReadLine();

                    c = c + 1;

                    Console.WriteLine("Cadastre SENHA:");
                    T[i, c] = senhaCad = Console.ReadLine();

                    Console.WriteLine("Seu cadastro esta completo, deseja volta para o menu? S/N");
                    final = Console.ReadLine();

                    switch (final)
                    {
                        case "S":
                        case "s":

                            return T;



                        case "N":
                        case "n":

                            break;

                        default:
                            return T;

                    }

                }

            }


            return T;

        }

        static string Login(string[,] T)
        {
            string nome, senha;
            Console.WriteLine("FAÇÃ O SEU LOGIN\n");

            Console.WriteLine("Digite O SEU NOME:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite A SUA SENHA:");
            senha = Console.ReadLine();

            if (nome == T[0,0] && senha == T[0,1])
            {

                return"Você está conectado";
            }
            else
            {

                return "Nome ou senha incorretos";
            }
            

        }

       
        

        static void Nomes()
        {
            string[] num = new string[3];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite {0}º nome:", i);
                num[i] = Console.ReadLine();
            }
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("nome: {1}", i, num[i]);
            }
        }

        static void Notas()
        {
            int[] num = new int[3];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite {0}º nota:", i);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Notas: {1}", i, num[i]);
            }
        }

        static void Contagem()
        {
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

     
    }  
}
