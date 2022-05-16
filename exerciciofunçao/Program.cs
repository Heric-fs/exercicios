using System;

namespace exerciciofunçao
{
    class Program
    {
        static void Main(double[] args)
        {
            double entrada;

            Console.WriteLine("Digites seus valores");
            entrada = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a opcao que deseja:");
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("0-Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {

            }
        }
    }






















    enum Operacao
    {
        Sair,
        adiçionar,
        subtrair,
        multiplicar,
        dividir,
    }









}

