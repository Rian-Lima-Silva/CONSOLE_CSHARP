using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeCad, nome;
            int senhaCad, senha;
            string usuario;
            
            Console.WriteLine("Cadastre o seu Nome:");
            nomeCad = Console.ReadLine();
            Console.WriteLine("Cadastre o seu Usuario(esse será o nome que aparecerá para as outras pessoas):");
            usuario = Console.ReadLine();
            Console.WriteLine("Digite a sua senha:");
            senhaCad = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o seu Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua senha:");
            senha = int.Parse(Console.ReadLine());
            
            if(nome==nomeCad && senha == senhaCad)
            {          
                Console.WriteLine("O Login de {0} foi feito com sucesso!",usuario);
            }
            else
            {
                Console.WriteLine("Sua nome ou senha foi digitada errada!");
            }

           

           
            
        }
    }
}
