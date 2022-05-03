using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            Console.WriteLine("ecreva sua idade");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escreva seu nome");
            nome = Console.ReadLine();
            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            } 
            else 
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
