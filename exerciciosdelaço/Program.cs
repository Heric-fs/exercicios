using System;

namespace exerciciosdelaço
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetorNomes = new string[10];
            for (int i = 0; i < vetorNomes.Length; i++)
            {
                Console.WriteLine("Escreva os nomes");
                vetorNomes[i] =(Console.ReadLine());
            }
            for(int i = 0; i < vetorNomes.Length; i++)
            {
                Console.WriteLine("nomes =" +  vetorNomes[i]);
            }




        }
    }
}
