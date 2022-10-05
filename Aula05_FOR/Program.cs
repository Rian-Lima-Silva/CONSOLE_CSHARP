using System;


namespace Aula05_FOR//Estudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*for(int i = 0; i<=10; i = i + 100)
            {
                Console.WriteLine("Contagem Crescente: "+i);
            }*/

           // Console.WriteLine("----------------------------------");
            
            for(int min=2; min>=0; min = min - 1)
            {
                for(int seg=60;seg>=0;seg=seg-1)
               
                Console.WriteLine("{0}:{1}",min,seg);     

            }

        }
    }
}
