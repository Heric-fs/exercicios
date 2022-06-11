using System;

namespace atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double retorno;

            Console.WriteLine("Digites os valores");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());

             retorno = Adicao(n1, n2);

            Console.WriteLine("A soma dos valores é"   + retorno);
        }
        static double Adicao(double n1, double n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }

    }
}
