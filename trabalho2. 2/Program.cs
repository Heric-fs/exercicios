using System;

namespace trabalho2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            int[] retorno;
            Console.WriteLine("Insira um valor:");
            entrada = Convert.ToInt32(Console.ReadLine());

            retorno = Divisores(entrada);

            MostraValores(retorno);
        }
        static void MostrarValores(int[] valores)
        {
            Console.WriteLine("Mostrando divisores:");

            if (valores[i] > 0)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
    static int[] divisores(int num)
    {
        int[] divisores = new int[num + 1];

        for (int i = 1; i < divisores.Length; i++)
        {
            if (num % i == 0)
            {
                divisores[i] = i;
            }
            return divisores;
        }
    }



}
