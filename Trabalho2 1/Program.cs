using System;

namespace Trabalho2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] entrada = new double[10];
            double iverso;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Isira os valores");
                entrada[i] = Convert.ToDouble(Console.ReadLine());
            }
            mostrarinverso(entrada);
            
        }
        static void mostrarinverso (double[] inverso)
        {
            for ( int i = 10; i > 0; i --)
            {
                Console.WriteLine(inverso[i]);
               
            }
        }
    }
}
