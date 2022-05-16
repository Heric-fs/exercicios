using System;

namespace exerciciodelaço3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ou;
            string[] vetortexto = new string[10];
            for (int i = 0; i < vetortexto.Length; i++)
            {
                Console.WriteLine("Escreva os textos");
                vetortexto[i] = (Console.ReadLine());
            }
                for (int i = 0; i < vetortexto.Length; i++)
            { 
                    Console.Write(vetortexto[i] + " -ou-");
            }

        }
    }
}
