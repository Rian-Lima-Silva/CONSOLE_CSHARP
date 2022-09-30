using System;

namespace Aula02
{
    class SegundaAula
    {
        static void Main(string[] args)
        {
            //int.parse

            double numero1, numero2;
            double resultado;
          
            

            Console.WriteLine("Digite o primeiro número:");
            numero1 = Convert.ToDouble(Console.ReadLine());
         
            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToDouble(Console.ReadLine());

            resultado = numero1 + numero2;
            Console.WriteLine("Soma: " + resultado);
            resultado = numero1 - numero2;
            Console.WriteLine("Subtração: " + resultado);
            resultado = numero1 * numero2;
            Console.WriteLine("Multiplicação: " + resultado);
            resultado = numero1 / numero2;
            Console.WriteLine("Divisão: " + resultado);

        }
    }
}