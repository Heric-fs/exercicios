using System.Collections.Generic;

namespace orientacaoobjeto3
{
    internal class Venda
    {
        internal Vendedor Vendedor;
        internal bool Finalizada;

        public Venda()
        {
        }

        public Venda(Cliente cliente, Vendedor vendedor1)
        {
        }

        public List<Produto> Produtos { get; internal set; }
        public object ValorTotal { get; internal set; }
        public Cliente Cliente { get; internal set; }
    }
}