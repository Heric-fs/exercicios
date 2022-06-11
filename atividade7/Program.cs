using System;

namespace atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            Console.WriteLine("Insira a opcao que deseja:");
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("0-Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {
                if (opcao == (int)Operacao.Adicionar)
                {
                    Console.WriteLine("Insira os numero ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());

                    double retorno = Adicao(num1, num2);

                    Console.WriteLine("Resultado" + retorno);
                }

                if (opcao == (int)Operacao.Subtrair)
                {
                    Console.WriteLine("Insira os numero ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());

                    double retorno = Subtracao(num1, num2);

                    Console.WriteLine("Resultado" + retorno);
                }

                if (opcao == (int)Operacao.Multiplicar)
                {
                    Console.WriteLine("Insira os numero ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());

                    double retorno = Multiplicacao(num1, num2);

                    Console.WriteLine("Resultado" + retorno);
                }

                if (opcao == (int)Operacao.Dividir)
                {
                    Console.WriteLine("Insira os numero ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());

                    double retorno = divisao(num1, num2);

                    Console.WriteLine("Resultado" + retorno);
                }


                Console.WriteLine("Insira a opcao que deseja:");
                Console.WriteLine("1-Adição");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                Console.WriteLine("0-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());



            }
        }
        static double Adicao(double n1, double n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }

        static double Subtracao(double n1, double n2)
        {
            double resultado = n1 - n2;
            return resultado;
        }

        static double Multiplicacao(double n1, double n2)
        {
            double resultado = n1 * n2;
            return resultado;
        }

        static double divisao(double n1, double n2)
        {
            double resultado = n1 / n2;
            return resultado;
        }
        enum Operacao
        {
            Sair,
            Adicionar,
            Subtrair,
            Multiplicar,
            Dividir,
        }
    }
}

