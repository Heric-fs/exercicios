using System;

namespace Trabalho2_3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int entrada;
            Console.WriteLine("Iforme um intervalo para adivinhar");
            entrada = Convert.ToInt32(Console.ReadLine());

            Random numeroaleatorio = new Random();
            int valoraleatorio = numeroaleatorio.Next(0,entrada);
         
            Console.WriteLine("Digite o numero");
            entrada = Convert.ToInt32(Console.ReadLine());


            while (valoraleatorio != entrada)
            {
                if (valoraleatorio > entrada)
                {
                    Console.WriteLine("O valor e maior");
                }
                else
                {
                    Console.WriteLine("O valor e menor"); 
                }
                Console.WriteLine("Digite o numero");
                entrada = Convert.ToInt32(Console.ReadLine());  
            }
            Console.WriteLine("Voçe acertou");

        }      
    }
}
