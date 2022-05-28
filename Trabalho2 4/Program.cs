using System; 

namespace Trabalho2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int contador = 2;
            int mdc = 1;

            Console.WriteLine("Digite o primeiro numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo  numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero");
            n3 = Convert.ToInt32(Console.ReadLine());

           
            while (contador <= n1 && contador <= n2 && contador <= n3)
            {
                if (n1 % contador == 0 && n2 % contador == 0 && n3 % contador == 0)
                {
                    mdc = mdc * contador;
                    n1 = n1 / contador;
                    n2 = n2 / contador;
                    n3 = n3 / contador;

                }
                contador = contador + 1;
            }
            Console.WriteLine(" O maximo divisor comum e :" + mdc.ToString());
            Console.Read();
        }


    }
}