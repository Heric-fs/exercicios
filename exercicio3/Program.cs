using System;

namespace exercicio3
{
    class Program
    {

        static void Main(string[] args)
        {

            int A = 0;
            int B = 0;
            int resultado=0;
            int adicao;
            int subtracao;
            int multiplicacao;
            int divisao;
            char opcaoOperacao;
            Console.WriteLine("ecreva o primeiro valor");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ecreva o segundo valor");
            B = Convert.ToInt32(Console.ReadLine());
            opcaoOperacao = Convert.ToChar(Console.ReadLine());

            if (opcaoOperacao == '+') 
            {
                adicao = A + B;
                Console.WriteLine("Resultado da soma é "+ adicao);
            }
            else if (opcaoOperacao == '-') 
            {
                subtracao = A - B;
            }

            adicao = ((A + B));
            subtracao = (A - B);
            multiplicacao = (A * B);
            divisao = (A / B);

            Console.WriteLine("A adicao entre os dois valores é " + adicao);
            adicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a subtracao é" + subtracao);
            subtracao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a multiplicacao é" + multiplicacao);
            multiplicacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a divisao é" + divisao);
            divisao = Convert.ToInt32(Console.ReadLine());
        }
    }
}