using System;

namespace trabalho2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[5];
            double dobro = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Digite os valores");
                valores[i] = Convert.ToDouble(Console.ReadLine());

                dobro = dobro + valores[i];

            }
            Console.WriteLine("Os valores dobrado sao " + dobro);

        }
    }
}              