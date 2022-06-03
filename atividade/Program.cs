using System;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            double res = 0;

            Console.WriteLine("Digite o primeiro valor");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(" Esse e o maior " + n1);

            }
            else if (n2 > n1) 
            {
                Console.WriteLine(" Esse e o maior " + n2);
            }

            else
            {
                Console.WriteLine(" os valores sao iguais");
            }

           
        }
    }
}
