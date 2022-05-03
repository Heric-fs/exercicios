using System;

namespace trabalho2
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1;
            double l2;
            double l3;
            Console.WriteLine(" digite o primeiro lado");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" digite o segundo lado");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" digite o terceiro lado");
            l3 = Convert.ToDouble(Console.ReadLine());
            if (l1 + l2 > l3 && l2 + l3 > l1 && l3 + l1 > 12)
            {
                Console.WriteLine("É um triangulo");
                if (l1 == l2 && l2 == l3 && l3 == l1)
                {
                    Console.WriteLine("É um triangulo equilatero ");
                }
                if (((l1 == l2) && (l2 != l3)) || ((l3 == l1) && (l1 != l2)) || ((l2 == l3) && (l1 != l3)))
                {
                    Console.WriteLine("É um triangulo");
                }
                if ((l1 != l2) && (l2 != l3) && (l3 != l1))
                {
                    Console.WriteLine("É um triangulo escaleno");
                }
            }

        }
    }
}
