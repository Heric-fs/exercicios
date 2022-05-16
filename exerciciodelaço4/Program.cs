using System;

namespace exerciciodelaço4
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada;
            double soma = 0;
            double media;
            double contador = 0;
            Console.WriteLine("Ecreva os valores");
            entrada = Convert.ToDouble(Console.ReadLine());
            while (entrada > 0 )
            {
                soma = soma + entrada ;
                contador = contador + 1;
                Console.WriteLine("Ecreva os valores");
                entrada = Convert.ToDouble(Console.ReadLine());
            }
            media= soma / contador;
            Console.WriteLine("A media é" + media);
        }
     
    }
}
