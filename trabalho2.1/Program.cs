using System;

namespace trabalho2._1
{
    class Program
    {
        static void Main(string[] args)                                    
        {
            double[] notas = new double[10];
            Random random = new Random();

            for (int i =0; i < notas.Length; i++)
            {
                Console.WriteLine("por favor, insira a nota do aluno:" + i);
                notas[i] = random.NextDouble() * 10;
            }

            bool[] resultados = AprovadosReprovados(notas);

            for (int i = 0; i < notas.Length; i++)
            {
                if (resultados[i])
                {
                    Console.WriteLine("aluno " + i + " aprovados");

                }
            }
        }
        static bool[] AprovadosReprovados(double[] notas)
        {
            bool[] aprovadosreprovados = new bool[notas.Length];
        for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > 7)
                {
                    aprovadosreprovados[i] = true;
                }
            }
            return aprovadosreprovados;
        }
    }
}