﻿using System;

namespace orientacaoobjeto3
{
    public class Vendedor
    {
        internal object CodigoCracha;
        internal string Codigo;

        public string Nome { get; set; }
        public string Cracha { get; set; }
      
  
        public Vendedor(string nome, string cracha)
        {
            this.Nome = nome;
            this.Cracha = cracha;
        }

        public Vendedor()
        {
        }

        public Vendedor(string nome, string cracha, object codigoCracha) : this(nome, cracha)
        {
        }

        class Program
        {
            static void Main(string[] args)
            {
                Vendedor vendedor1 = new Vendedor("CARLOS", "005367");

                Console.WriteLine("Nome: " + vendedor1.Nome);
                Console.WriteLine("Nome: " + vendedor1.Cracha);


                Vendedor vendedor2 = new Vendedor("JOSE", "105368");

                Console.WriteLine("Nome: " + vendedor2.Nome);
                Console.WriteLine("Nome: " + vendedor2.Cracha);

            }
        }
    }
}
