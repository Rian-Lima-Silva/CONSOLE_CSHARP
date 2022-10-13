using System;

namespace Aula06_Metodos_02//COM Parametros + TIPO:Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            string f = "| COM PARAMETRO";

            E("N1");
            n1 =double.Parse(Console.ReadLine());
            E("N2");
            n2 = double.Parse(Console.ReadLine());


            E("Esse é um teste de fazer um WriteLine com Método");
            E();
            Frase(f);
            E();
            Soma(n1, n2,f);
            E();
            Sub(n1, n2, f);
            E();
            Multi(n1, n2, f);
            E();
            Div(n1, n2, f);
            E();

        }
        public static void E(string nome = "-------------------------------------")
        {
            Console.WriteLine(nome);
        }
        public static void Frase(string f)
        {
            Console.WriteLine("Esse é o método que digitas frases! {0}",f);
            
        }
        public static void Soma(double n1, double n2, string f)
        {

            double res;
            res = n1 + n2;
            Console.WriteLine("Esse é o resultado da Soma: {0}{1}", res,f);
        }
        public static void Sub(double n1, double n2, string f)
        {
            double res;
            res = n1 - n2;
            Console.WriteLine("Subtração: {0}{1}", res, f);
        }
        public static void Multi(double n1, double n2, string f)
        {
            double res;
            res = n1 * n2;
            Console.WriteLine("Multiplicação: {0}{1}", res, f);
        }
        public static void Div(double n1, double n2, string f)
        {
            double res;
            res = n1 / n2;
            Console.WriteLine("Divisão: {0}{1}", res, f);
        }
    }
}
