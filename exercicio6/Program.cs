using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa;
            double xb;
            double ya;
            double yb;
            double resultados;
            Console.WriteLine("Digite a primeira coordenada xa");
            xa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda coordenada xb");
            xb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira coordenada ya");
            ya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta coordenada yb");
            yb = Convert.ToDouble(Console.ReadLine());
            resultados = ((xa - xb )*(xa - xb)) + ((ya - yb) * (ya - yb));
            resultados = Math.Sqrt(resultados);
            Console.WriteLine("Resultado" + resultados);



        }
    }
}
