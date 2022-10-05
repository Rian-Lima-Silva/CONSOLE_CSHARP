using System;


namespace Aula05_FOR//Desafio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,fatorial;
            

            Console.WriteLine("Qual o número que dev ser processado:");
            num = int.Parse(Console.ReadLine());
            
            //5!=1*2*3*4*5
            //5!=120

            fatorial = num;
            for (int i = num- 1; i >= 1; i=i-1)
            {
               

                fatorial=fatorial * i;

     

            }


            Console.WriteLine("{0}!={1}",num,fatorial);

        }
    }
}
