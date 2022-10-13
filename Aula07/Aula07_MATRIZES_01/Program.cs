using System;

namespace Aula07_MATRIZES_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vetores: [POSIÇÃO]
             Matriz: [Linha e Coluna] [1,2]=Uma Linha e duas colunas
            Ex:
            Cadastro de 1 pessoa:Dados->Nome,Email,Senha
            Matriz[1,3] ou Matriz[1 Linha e 3 Colunas]
            
             Cadastro de 2 pessoas:Dados->Nome,Email,Senha
            Matriz [2,3] ou Matriz [2 Linha e 3 Colunas]*/


            string[,] n = new string[3, 3];

         
               n[0, 0] = "Nome";
               n[0, 1] = "Sobrenome";
               n[0, 2] = "Final";
             
               n[1, 0] = "";
               n[1, 1] = ""; 
               n[1, 2] = "";

               n[2, 0] = "";
               n[2, 1] = "";
               n[2, 2] = "";
              

            for (int i = 0; i <3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                   
                        Console.WriteLine("Digite o seu NOME:");
                        n[i, a] = Console.ReadLine();
                }

            }

            for (int i = 0; i < 3; i++)
            {               
                    Console.WriteLine("{0}º {1} {2} {3}", i, n[i, 0], n[i, 1], n[i, 2]);
            }
            
            

        }
    }
}
