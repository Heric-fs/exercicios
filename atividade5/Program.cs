using System;

namespace atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            Random random = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = random.Next(0, 10);
                Console.WriteLine(valores[i] * i);
            }
        }
    }
}
