using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoje = 2022 ;
            double ano ;
            double resultado;

            Console.WriteLine("Digite o ano do seu nascimento");
            ano = Convert.ToDouble(Console.ReadLine());

            resultado = hoje - ano;

            Console.WriteLine("Voce tem " + resultado);
            

            // int resultado = datetime.now.year - ano
        }
    }
}
