using System;

namespace exerciciodelaço6
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = Convert.ToInt32(Console.ReadLine());
            double[] vetorinteiro = new double[entrada];
            double[] vetor1 = new double[entrada];
            double[] vetor2 = new double[entrada];
            double[] vetorAuxiliar = new double[entrada];

            for (int i = 0; i < vetorinteiro.Length; i++)
            {
                Console.WriteLine("Digite o valor");
                vetorinteiro[i]= Convert.ToDouble(Console.ReadLine());
                vetor1[i] = vetorinteiro[i];

            }
            for (int i = 0; i < vetorinteiro.Length; i++)
            {
                for (int j = 0; j < vetorinteiro.Length; j++) 
                {
                    if (i != j) 
                    {
                        if (vetorinteiro[i] == vetor1[j]) 
                        {
                            vetor2[i]++;
                        }
                    }
                }
            }
            //for(int i = 0; i < vetorinteiro.Length; i++)
            //{
            //    for (int j = 0; j < vetorinteiro.Length; j++)
            //    {
            //        if(i != j) 
            //        {
            //            if (vetorinteiro[i] == vetor1[j] && vetorAuxiliar[j] == 0)
            //            {
            //                vetor2[i]++;
            //                vetorAuxiliar[i] = 1;
            //                vetorAuxiliar[j] = -1;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < vetorinteiro.Length; i++)
            //{
            //    if (vetor2[i] > 0 && vetorAuxiliar[i] > 0) 
            //    {
            //        //Console.WriteLine("O valor " + vetorinteiro[i] + " se repete " + vetor2[i] + " vezes." );
            //        Console.WriteLine($"O valor {vetorinteiro[i]} na posição {i} se repete {vetor2[i]}.");
            //    }
            //}
            for (int i = 0; i < vetorinteiro.Length; i++)
            {
                if (vetor2[i] > 0)
                {                    
                    Console.WriteLine($"O valor {vetorinteiro[i]} na posição {i} se repete {vetor2[i]}.");
                }
            }

        }
    }
}
