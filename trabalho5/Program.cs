using System;

namespace trabalho5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ano;
            double resultado;
            Console.WriteLine("Digite o ano");
            ano = Convert.ToDouble(Console.ReadLine());
            resultado = Convert.ToDouble(Console.ReadLine());
            if ((ano % 400) == 0)
            {
                //Console.WriteLine("Ano bissexto");
                if ((ano % 4) == 0)
                {
                    //Console.WriteLine("Ano bissexto");
                    if ((ano % 100) > 0)
                    {
                        Console.WriteLine("Ano bissexto");
                    }
                }
            }
        }
    }
}
