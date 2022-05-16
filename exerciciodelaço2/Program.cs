using System;

namespace exerciciodelaço2
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior = 0;
            double menor = 10;
            double soma = 0;
            double[] vetorInteiro = new double[10];
            for (int i = 0; i < vetorInteiro.Length; i++)
            {
                Console.WriteLine("Digite as nota");
                vetorInteiro[i] = Convert.ToDouble(Console.ReadLine());
                soma = soma + vetorInteiro[i];
                if ( vetorInteiro[i] > maior)
                {
                    maior = vetorInteiro[i];
                 
                }
                 if ( vetorInteiro[i] < menor)
                {
                    menor = vetorInteiro[i];

                }
            }
            soma = soma / 10;
            Console.WriteLine("A media é " + soma);
            Console.WriteLine("A maior nota é " + maior);
            Console.WriteLine("A menor nota é " + menor);

        }
    }
}
