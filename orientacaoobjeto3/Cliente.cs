using System;
using System.Collections.Generic;
using System.Text;

namespace orientacaoobjeto3
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereço { get; set; }

        public Cliente(string nome, string cpf, string endereco)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereço = endereco;
        }
        public Cliente()
        {
        }

        class Program
        {
            static void Main(string[] args)
            {
                Cliente cliente1 = new Cliente("HERIC", "08168871103", "Rua vasconcelos Drumont");

                Console.WriteLine("Nome: " + cliente1.Nome);
                Console.WriteLine("Nome: " + cliente1.Cpf);
                Console.WriteLine("Nome: " + cliente1.Endereço);

                Cliente cliente2 = new Cliente("Pedro", "08168871402", "Rua Brusque");

                Console.WriteLine("Nome: " + cliente2.Nome);
                Console.WriteLine("Nome: " + cliente2.Cpf);
                Console.WriteLine("Nome: " + cliente2.Endereço);


            }
        }

    } 
}
