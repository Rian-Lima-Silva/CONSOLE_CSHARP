using System;


namespace Aula04_Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*01.Faça um programa para leitura de duas notas parciais de um aluno.
             A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
             A mensagem "Aprovado com Distinção", se a média for igual a dez;
             A mensagem "Reprovado", se a média for menor do que sete;*/

            int nota1, nota2, media;
            string resultado;
            string nome;

            Console.WriteLine("As notas vão de 0 até 100!");

            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a 1º nota:");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a 2º nota:");
            nota2 = int.Parse(Console.ReadLine());

            media = nota1 + nota2;
            media = media / 2;

            if(media>=7)
            {
                if(media==10)
                {
                    resultado = "APROVADO COM DISTINÇÃO!!!";
                }
                else

                {
                    resultado = "APROVADO!";
                }
            }
            else
            {
                resultado = "REPROVADO!!!";
            }

            Console.WriteLine("Com base nos resultados obtidos previamente, o aluno {0} será {1}",nome,resultado);
        }
    }
}
