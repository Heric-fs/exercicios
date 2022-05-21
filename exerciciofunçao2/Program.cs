using System;

namespace exerciciofunçao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]entrada = new double[10];
            double maior = 0;

            maior = encontrarmaior(entrada);
            Console.WriteLine(" maior valor" + maior);
        }
        static double encontrarmaior (double[] valores)
        {
            double retorno = 0; 

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Insira os valores");
                valores[i] = Convert.ToDouble(Console.ReadLine());

                if (valores[i] > retorno)
                {
                    retorno = valores[i];

                }
              //  Console.WriteLine("O maior é" + retorno);

            }
            return retorno;
        }

    }
}
