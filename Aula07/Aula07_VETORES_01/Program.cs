using System;

namespace Aula07_VETORES_01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] n = new int[4] {0,1,2,3};
            string[] L = new string[4] {"Nome","Um","Dois","Três"};


             for (int i = 0; i < 4; i++)
             {
                Console.WriteLine("Contando: {0}|{1}", n[i],L[i]);
                             
             }

            //string[,] L = new string[2,3];

            /*Ao colocar no FOR é melhor usar a Linha com index, pois melhora a impressão de informações
             EX:Cadastro de 2 pessoa:Dados->Nome,Email,Senha
                                |   | 0 | 1 | 2 |
                n[0,0]=nome     | 0 |   |   |   |
                n[0,1]=email    | 1 |   |   |   |
                n[0,2]=senha    |---------------|
                                
                                
                Matriz[2,3] ou Matriz[2 Linha e 3 Colunas]
                Nessa Matriz e melhor usar o nome da pessoa como index
                n[i,0] = n[Linha(i),e coluna 0)
                Console.WriteLine(n[i,0],n[i,1],n[i,2]); == Escreva n[index=0,coluna=0]
            
            
             
             */
                /*for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("{0}\n{1}\n{2}\n",n[i,0], n[i,1], n[i,2]);


                }*/


}
}
}
