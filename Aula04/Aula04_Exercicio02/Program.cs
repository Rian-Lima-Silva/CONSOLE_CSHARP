using System;

namespace Aula04_Desafio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*02 Faça um programa que pergunte o preço de três produtos e inform qual produto você deve comprar,
             sabendo que a decisão e sempre o mais barato.*/

            int p1, p2, p3;
            string resultado="";
            

            Console.WriteLine("Qual o preço do produto 1:");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço do produto 2:");
            p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço do produto 3:");
            p3 = int.Parse(Console.ReadLine());

            

            if(p1<p2 && p1<p3)
            {
               resultado="Produto 1";

                
            }
            else
            {
                if (p2 < p1 && p2 < p3)
                {
                    resultado = "Produto 2";
                }
                else
                {
                    resultado = "Produto 3";
                }
            }

            Console.WriteLine("O {0} deve ser comprado, pois tem um preço menor.",resultado);
            
        }
    }
}
