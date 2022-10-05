using System;

namespace Aula04_Desafio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste,aumento;
            reajuste = 0;
            aumento = 0;
            
            //Recebe o Salario do colaborador
            Console.WriteLine("Qual o seu salario:");
            salario = Convert.ToDouble(Console.ReadLine());

            //Calculo
            if (salario <= 280)
            {
                aumento = salario * 0.2;
                reajuste = salario + aumento;// Menor ou igual 280

                if (salario > 280 && salario < 700)
                {
                    aumento = salario * 0.15;
                    reajuste = salario + aumento;// entre 280 e 700

                    if (salario> 700 && salario<1500)
                    {
                        aumento = salario * 0.1;
                        reajuste = salario + aumento;// entre 700 e 1500

                        if (salario>=1500)
                        {
                            aumento = salario * 0.05;
                            reajuste = salario + aumento;// maior que 1500
                        }
                    }
                }               
            } 

            //Reajuste
            Console.WriteLine("\nSalario:R${0}\n\nAumento:R${1}\n\nNovo Salario:R${2}\n"
            ,salario,aumento,reajuste);            
        }

    }
}
