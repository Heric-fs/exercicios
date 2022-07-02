using System;
using System.Collections.Generic;
using System.Text;

namespace orientacaoobjeto3
{
    class Carrinhoa
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

    }
    class Proga
    {
        static void ListarProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Marca: {produto.Marca}");
                Console.WriteLine($"Preço: {produto.Preco}");
            }
        }
    }

}
