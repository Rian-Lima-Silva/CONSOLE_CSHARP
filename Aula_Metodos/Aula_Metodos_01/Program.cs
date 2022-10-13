using System;

namespace Aula06_Metodos_01//SEM Parametros + TIPO:Void
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Frase();
            
            Soma();
            
            Sub();
            
            Multi();
            
            Div();         
        }
        public static void E(string nome="-------------------------------------")
        {
            Console.WriteLine(nome);
        }
        public static void Frase()
        {
            Console.WriteLine("Esse é o método que digitas frases!");
        }
        public static void Soma()
        {

            double n1 = 10, n2 = 5, res;
            res = n1 + n2;
            Console.WriteLine("Esse é o resultado da Soma: {0}",res);
        }      
        public static void Sub()
        {
            double n1 = 10, n2 = 5, res;
            res = n1 - n2;
            Console.WriteLine("Subtração: {0}",res);
        }
        public static void Multi()
        {
            double n1 = 10, n2 = 5, res;
            res = n1 * n2;
            Console.WriteLine("Multiplicação: {0}", res);
        }
        public static void Div()
        {
            double n1 = 10, n2 = 5, res;
            res = n1 / n2;
            Console.WriteLine("Divisão: {0}",res);
        }
    }
}
