using System;

namespace trabalho_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[7];
            int[] vetor = new int[7];
            Random random = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = random.Next(0, 10);
            }

            for (int i = 0; i < valores.Length; i++)
            {
                vetor[i] = valores[i];
            }
               

        }
    }
}
