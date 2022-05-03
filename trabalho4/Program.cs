using System;

namespace trabalho4
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;
            double resultado;
            Console.WriteLine("Digite seu salario");
            salario = Convert.ToDouble(Console.ReadLine());
            aumento = Convert.ToDouble(Console.ReadLine());
            resultado = (salario / 100) * aumento;
            if (salario <= 1200)
            {
                Console.WriteLine(" valor com aumento" + ( 20 / 100 * salario) + salario);
            }
            else if (salario <= 2000)
            {
                Console.WriteLine(" valor com aumento" + (13/ 100 * salario) + salario);
            }
            else if (salario <= 2500)
            {
                Console.WriteLine(" valor com aumento" + (10 / 100 * salario) + salario);
            }
            else if (salario >= 2500)
            {
                Console.WriteLine(" valor com aumento" + (5 / 100 * salario) + salario);
            }
        }
    }
}
