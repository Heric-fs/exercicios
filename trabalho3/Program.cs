using System;

namespace trabalho3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            double maior;
            double menor;
            double meio;
            Console.WriteLine("Digite o primeiro numero");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segumdo numero");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero");
            n3 = Convert.ToDouble(Console.ReadLine());
            if ((n1 > n2) && (n1 > n3))
            {
                maior = n1;
                if (n2 > n3) 
                {
                    meio = n2;
                }
                else 
                {
                    meio = n3;
                }
            }
            else if ((n2 > n1) && (n2 > n3))
            {
                maior = n2;
                if ( n1 > n3)
                {
                    meio = n1;
                }
                else
                {
                    meio = n3;
                }
            }
            else if ((n3 > n1) && (n3 > n2))
            {
                maior = n3;
                if (n3 > n2)
                {
                    meio = n3;
                }
                else
                {
                    meio = n2;
                }
            }
            Console.WriteLine(" A maior numero é " + n1);

            if ((n1 < n2) && (n1 < n3))
            {
                menor = n1;
            }
            else if (( n2 < n1) && (n2 < n3))
            {
                menor = n2;
            }
            else if (( n3 < n1) && ( n3 < n2))
            {
                menor = n3;
            }

        }
    }
}
