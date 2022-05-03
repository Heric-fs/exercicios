using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double produto;
            double desconto;
            double resultado;
            double valor;
            Console.WriteLine("Digite o valor do produto");
            produto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do desconto");
            desconto = Convert.ToDouble(Console.ReadLine());
            resultado = (produto / 100) * desconto;
            valor = produto - resultado;
            if (produto <= 100 )
            {
                Console.WriteLine(" valor do imposto " + 5 / 100 * produto);
            }
            else if (produto <= 300 &&  produto > 100)  
            {
                Console.WriteLine(" valor do imposto " + 15 / 100 * produto);
            }
             else if (produto <= 1000 && produto > 300 )
            {
                Console.WriteLine("valor do imposto " + 25 / 100 * produto);
            }


        }
    }
}
