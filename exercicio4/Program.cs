using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1;
            double N2;
            double N3;
            double media;
            double maior;
            double menor;
            Console.WriteLine("escreva a primeira nota");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva a segunda nota");
            N2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva a terceira nota");
            N3 = Convert.ToDouble(Console.ReadLine());
            media = (N1 + N2 + N3) / 3;

            Console.WriteLine("A média é: "+media);

            maior = N1;

            if((N1 > N2) && (N1 > N3)) 
            {
                maior = N1; 
            }
            else if((N2>N1) && (N2> N3))
            {
                maior = N2;
            }
            else if((N3 > N1) && (N3 > N2))
            {
                maior = N3;
            }

            Console.WriteLine("a maior nota é " + N1);

            if ((N1 < N2) && (N1 < N3))
            {
                menor = N1;
            }
            else if ((N2 < N1) && (N2 < N3))
            {
                menor = N2;
            }
            else if ((N3 <  N1) && (N3 < N1))
            {
                menor = N3;
            }
            Console.WriteLine("a menor nota e " + N1);
            //if (N1 >= 10)
            //{
            //    Console.WriteLine("maior nota");
            //}
            //else
            //{
            //    Console.WriteLine("menor nota");
            //}
            //if (N2 >= 10)
            //{
            //    Console.WriteLine("maior nota");
            //}
            //else
            //{
            //    Console.WriteLine("menor nota");
            //}
            //if (N3 >= 10) 
            //{
            //    Console.WriteLine("maior nota");
            //}
            //else
            //{
            //    Console.WriteLine("menor nota");
            //}

        }
    }
}
