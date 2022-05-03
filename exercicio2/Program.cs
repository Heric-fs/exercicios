using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;
            Console.WriteLine("Digite seu peso");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            altura = Convert.ToDouble(Console.ReadLine());
            imc = peso/ (altura*altura);
            Console.WriteLine(" valor do IMC "+imc);
            

        }
    }
}
