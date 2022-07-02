using System;

namespace atividadefuncao
{
    class Program
    {
        static void Main(string[] args)
        {
        int entrada = Convert.ToInt32(Console.ReadLine());
        double[] valorusario = new double[entrada];
    
       for (int i = 0; i < valorusario.Length; i++)
       {

         valorusario[i] = valorrecebido();
       }

        }
    static double valorrecebido()
    {
         Console.WriteLine("Digite a quantidade de entrada que deseja inserir");
         return Convert.ToDouble(Console.ReadLine());

    }

    }
}

   /* class Progam

    {
        static void Main(string[] args)
        {
            double[] entrada = new double[10];

            for (int i = 0; i < entrada.Length; i++)
            {
                entrada[i] = Convert.ToDouble(Console.ReadLine());

            }
            Somar(entrada);
        }
        static void Somar(double[] entrada)
        {
            double soma = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                
               
                soma = entrada[i] + soma;

                
            }
            Console.WriteLine($"a soma é" + soma);
        }
    }

 }
   */