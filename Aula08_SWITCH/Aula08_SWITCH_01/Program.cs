using System;
using System.Collections.Generic;

namespace Aula08_SWITCH_01
{
    class Aula08_SWITCH
    {
        static void Main(string[] args)
        {
            /*1º Tela: Cadastro e Login
             2º Tela: Calculadora, */

            char menu=' ';
            string retorno;
            string nomeCad="", senhaCad="";
            
            

                inicio:     
                Console.Clear();
                Console.WriteLine("Tela de Login\n");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Login");
                Console.WriteLine("Escolha uma das opções acima");
                menu = char.Parse(Console.ReadLine());

                switch (menu)
                {
                    case '1':
                        Console.Clear();
                        Cadastro(nomeCad,senhaCad);
                    Console.WriteLine("Deseja retorna? \n 1-Menu de Login\n 2- Login");
                    retorno = Console.ReadLine();

                    if(retorno=="1")
                    {                                      
                       goto inicio;
                    }
                    else
                    {
                        goto login;

                    }

                    break;

                    case '2':
                        login:
                        Console.Clear();
                        Console.WriteLine(Log(nomeCad, senhaCad));
                    Console.WriteLine("Deseja retorna? \n 1-Menu de Login\n 2- Menu de Opções");
                    retorno = Console.ReadLine();
                    if (retorno == "2")
                    {
                        
                        goto TelaMenu;
                    }
                    else
                    {
                        goto inicio;
                    }
                    break;
                }
            
            TelaMenu:
            Console.Clear();
            Console.WriteLine("MENU DE OPÇÕES\n");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Matriz de Nomes");
            Console.WriteLine("Selecione a opção acima:");
            menu = char.Parse(Console.ReadLine());

            switch (menu)
            {
                case '1':
                    Console.Clear();
                    Calculadora();
                    break;

                case '2':
                    Matriz();
                    break;
            }

        }

        static string Cadastro(string nomeCad,string senhaCad)
        {

            string nome, senha;
            Console.WriteLine("Cadastre o seu nome:");
            nome=Console.ReadLine();
           Console.WriteLine("Cadastre a sua senha:");
            senha = Console.ReadLine();

            Console.WriteLine("Seu Cadastro está completo\n");

            return nomeCad = nome; senhaCad = senha;

        }
        static string Log(string nomeCad, string senhaCad)
        {
            string nome, senha;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua senha:");
            senha = Console.ReadLine();

            if (nome== nomeCad && senha == senhaCad)
            {
                return "Você esta conectado";
            }
            else
            {
                return "Seu nome ou senha estão incorretos";
            }
        }

        static void Calculadora()
        {
            double n1,n2,res=0;
            char op;
            Console.WriteLine("Digite o 1º número");
            n1=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            op =char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            n2 =double.Parse(Console.ReadLine());

            switch(op)
            {
                case '+':
                    res = n1 + n2;
                    break;
                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                case '/':
                    res = n1 / n2;
                    break;
            }    

            Console.WriteLine("\nRESULTADO: {0}",res);
            
        }
        static void Matriz()
        {
            string[,] nome = new string[3, 2];

            for(int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 2; c++)
                {
                    Console.Clear();
                    if (c == 0)
                    {
                        Console.WriteLine("Digite o seu nome");
                        nome[l, c] = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Digite o seu sobrenome");
                        nome[l, c] = Console.ReadLine();
                    }

                }
                
            }

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Nome COmpleto: {0} {1}", nome[i, 0], nome[i,1]);
            }
        }

        
    }
}
