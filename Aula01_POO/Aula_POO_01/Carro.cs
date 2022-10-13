using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_01
{
    internal class Carro
    {
        //Atributos

        public List<string> Marca = new List<string>();
        public List<string> Modelo = new List<string>();
        public List<string> Cor = new List<string>();
        public List<string> Combustivel = new List<string>();
        public List<string> Precos = new List<string>();

        public static void Veiculos(string menu, int L, Carro objCarro)
        {
            Console.WriteLine("COMPRA DE CARROS:");
            Console.WriteLine("1 - Ford");
            Console.WriteLine("2 - Mitsubishi");
            Console.WriteLine("Escolha qual você deseja observar mais detalhes:");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                case "Ford":
                case "ford":
                case "f":
                    Console.Clear();
                    L = 0;
                    Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}\nTipo de Combustivel: {3}\nPreço: {4}\n",
                    objCarro.Marca[L], objCarro.Modelo[L], objCarro.Cor[L], objCarro.Combustivel[L], objCarro.Precos[L]);

                    break;

                case "2":
                case "Mitsubishi":
                case "mitsubishi":
                case "m":
                    Console.Clear();
                    L = 1;
                    Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}\nTipo de Combustivel: {3}\nPreço: {4}\n",
                     objCarro.Marca[L], objCarro.Modelo[L], objCarro.Cor[L], objCarro.Combustivel[L], objCarro.Precos[L]);

                    break;
            }
        }

        public static void Calculadora(string menu)
        {
            double n1, n2, res=0;
            

            Console.WriteLine("Nº1");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Operação");
            menu = Console.ReadLine();
            Console.WriteLine("Nº2");
            n2 = double.Parse(Console.ReadLine());

            if (menu=="+")
            {
                res = n1 + n2;              
                
            }
            else if (menu == "-")
            {
               res = n1 - n2;                                 
            }
            else if(menu == "*")
            {
                res = n1 * n2;               
            }else if (menu == "-")
            {
                res = n1 / n2;
            }
            else
            {
              Console.WriteLine("Apenas as operações Soma(+),Subtração(-),Multiplicação(*),Divisão(/) são aceitas," +
                " o uso do sinal ({0}) é invalido", menu);
            }

            Console.WriteLine("RESULTADO: {0}{1}{2}={3}", n1, menu, n2, res);
        }
      
        

        

       









    }
}
