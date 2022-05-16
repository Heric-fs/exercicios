using System;

namespace exerciciodelaço7
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                string[] numeroContas = new string[5];
                double[] saldoContas = new double[5];

                //pegando as contas dos usuários e os saldos das mesmas;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Insira o código da conta " + i);
                    numeroContas[i] = Console.ReadLine();
                    Console.WriteLine("Insira o saldo da conta " + i);
                    saldoContas[i] = Convert.ToDouble(Console.ReadLine());
                }

                //mostrando o menu na tela e pegando a opção do usuário;

                Console.WriteLine("Insira a opcao que deseja:");
                Console.WriteLine("1-Sacar");
                Console.WriteLine("2-Depositar");
                Console.WriteLine("3-Transferir");
                Console.WriteLine("0-Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                while (opcao != (int)Operacao.Sair)
                {
                    if (opcao == (int)Operacao.Sacar)
                    {
                        Console.WriteLine("Por favor, informe a conta para saque:");
                        string contaSaque = Console.ReadLine();

                        for (int i = 0; i < 5; i++)
                        {
                            if (contaSaque == numeroContas[i])
                            {
                                Console.WriteLine("Informe o valor para saque");
                                double valorSaque = Convert.ToDouble(Console.ReadLine());
                                if (saldoContas[i] >= valorSaque)
                                {
                                    saldoContas[i] = saldoContas[i] - valorSaque;
                                    Console.WriteLine("Saque efetuado.");
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente.");
                                }
                            }
                        }
                    }
                    else if (opcao == (int)Operacao.Depositar)
                    {
                        Console.WriteLine("Por favor, informe a conta para saque:");
                        string contaSaque = Console.ReadLine();

                        for (int i = 0; i < 5; i++)
                        {
                            if (contaSaque == numeroContas[i])
                            {
                                Console.WriteLine("Informe o valor para depósito");
                                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                                saldoContas[i] = saldoContas[i] + valorDeposito;
                                Console.WriteLine("Valor depositado.");
                                //ou assim:
                                //saldoContas[i] += valorDeposito;
                            }
                        }
                    }
                    else if (opcao == (int)Operacao.Transferir)
                    {
                        Console.WriteLine("Por favor, informe a conta de origem:");
                        string contaOrigemTransfer = Console.ReadLine();

                        Console.WriteLine("Por favor, informe a conta de destino:");
                        string contaDestinoTransfer = Console.ReadLine();

                        string contaOrigemEncontrada = string.Empty;
                        int posicaoOrigem = 0;

                        string contaDestinoEncontrada = string.Empty;
                        int posicaoDestino = 0;

                        if (contaOrigemTransfer != contaDestinoTransfer)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                //encontra a conta origem e guarda a conta, a referência dentro do vetor e o saldo;
                                if (contaOrigemTransfer == numeroContas[i])
                                {
                                    Console.WriteLine("Conta origem encontrada.");
                                    contaOrigemEncontrada = numeroContas[i];
                                    posicaoOrigem = i;
                                }
                                //procura a conta destino e guarda a conta, a referência dentro do vetor e o saldo;
                                if (contaDestinoTransfer == numeroContas[i])
                                {
                                    Console.WriteLine("Conta destino encontrada.");
                                    contaDestinoEncontrada = numeroContas[i];
                                    posicaoDestino = i;
                                }
                            }

                            if (!string.IsNullOrEmpty(contaOrigemEncontrada) && !string.IsNullOrEmpty(contaDestinoEncontrada))
                            {
                                Console.WriteLine("Informe o valor para transferência");
                                double valorTransfer = Convert.ToDouble(Console.ReadLine());
                                if (saldoContas[posicaoOrigem] >= valorTransfer)
                                {
                                    saldoContas[posicaoOrigem] = saldoContas[posicaoOrigem] - valorTransfer;
                                    saldoContas[posicaoDestino] += valorTransfer;
                                    Console.WriteLine("Valor transferido");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Uma das contas ou as duas não foram encontradas.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Informe contas diferentes para a operação.");
                        }
                    }

                    Console.WriteLine("Insira a opcao que deseja:");
                    Console.WriteLine("1-Sacar");
                    Console.WriteLine("2-Depositar");
                    Console.WriteLine("3-Transferir");
                    Console.WriteLine("0-Sair");
                    opcao = Convert.ToInt32(Console.ReadLine());
                }

                //int contadorContas = Convert.ToInt32(Console.ReadLine());
                //int j = 0;
                //while (j < contadorContas)
                //{
                //    Console.WriteLine("Insira o código da conta " + j);
                //    numeroContas[j] = Console.ReadLine();
                //    Console.WriteLine("Insira o saldo da conta " + j);
                //    saldoContas[j] = Convert.ToDouble(Console.ReadLine());
                //    j++;
                //}
            }
        }
        enum Operacao
        {
            Sair,
            Sacar,
            Depositar,
            Transferir
        }

    }
}
   
