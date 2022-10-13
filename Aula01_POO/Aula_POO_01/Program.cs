using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objCarro= new Carro();
            

            /*SINTAXE para declaração de metodo em outra class:
             * 
             <class name>.Metodo();
             classe:Carro
             Metodo:public static void Soma();

             DECLARAÇÃO NO MÉTODO MAIN: Carro.Soma()*/

            string menu;
            int L=2;

            //Declaração da Marca
            objCarro.Marca.Add("Ford");
            objCarro.Marca.Add("Mitsubishi");

            //Declaraçao Modelo
            objCarro.Modelo.Add("Fiesta");
            objCarro.Modelo.Add("L-200");

            //Declaraçao Cor
            objCarro.Cor.Add("Branco");
            objCarro.Cor.Add("Azul Royal");

            //Declaraçao Combustivel
            objCarro.Combustivel.Add("Gasolina");
            objCarro.Combustivel.Add("Diesel");

            //Declarar Preços
            objCarro.Precos.Add("R$ 500,000");
            objCarro.Precos.Add("R$ 520,000");

            Console.WriteLine("TELA INICIAL");
            Console.WriteLine("1 - COMPRA DE CARROS");
            Console.WriteLine("2 - Calculadora");
            Console.WriteLine("Escolha qual você deseja observar mais detalhes:");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.Clear();         
                    Carro.Veiculos(menu, L, objCarro);
                    break;
                case "2":
                    Console.Clear();
                    Carro.Calculadora(menu);
                    break;
            }
                   
        }
    }
}
