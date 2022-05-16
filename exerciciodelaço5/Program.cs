using System;

namespace exerciciodelaço5
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] vetor1 = new double[5];
            double[] vetor2 = new double[5];
            double [] vetor3 = new double[5];
            double soma = 0;
         

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digites os valores A");
                vetor1[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digites os valores B");
                vetor2[i] = Convert.ToDouble(Console.ReadLine());                
            }
            for (int i = 0; i < vetor3.Length; i++)
            {
                vetor3[i] = vetor1[i] * vetor2[i];

            }
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine(" A multipliçao é" + vetor3[i]);
            }

        }
    }
}