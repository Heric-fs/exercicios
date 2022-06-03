using System;

namespace Trabalho2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double res;

            Console.WriteLine("Digite o primeiro numero");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero ");
            n2 = Convert.ToDouble(Console.ReadLine());

            res = n1 + n2;
            Console.WriteLine("A soma é " + res);
            
        }
    }
}
