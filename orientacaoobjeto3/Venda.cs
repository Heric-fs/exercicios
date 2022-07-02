using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace orientacaoobjeto3
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public Produto(int codigo, string descricao, string marca, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Preco = preco;
        }
        public override string ToString()
        {
            return $"{this.Codigo} {this.Marca} {this.Descricao} {this.Preco}";
        }
        public static List<Produto> PreencherProdutos(List<Produto> produtos)
        {
            produtos.Add(new Produto(1, "Picanha a vácuo", "Friboi", 75));
            produtos.Add(new Produto(2, "Contra File ", "Friboi", 75));
            produtos.Add(new Produto(3, "Cupin a vácuo", "Friboi", 75));
            produtos.Add(new Produto(4, "Maminha a vácuo", "Friboi", 75));
            produtos.Add(new Produto(5, "figado ", "  Friboi", 75));
            produtos.Add(new Produto(6, " File Miong vácuo", "Friboi", 75));
            produtos.Add(new Produto(7, "lombo a vácuo", "Friboi", 75));
            produtos.Add(new Produto(10, "Figado ", "Friboi", 75));
            return produtos;
        }
    }
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; }
    }
    enum Opcoes
    {
        CadastrarCliente,
        CadastrarVendedor,
        CadastrarProduto,
        CriarVenda,
        InserirNoCarrinho,
        LimparCarrinho,
        FinalizarVenda
    }
    class Program
    {
        static List<Produto> CopiarProdutosParaOutraLista(List<Produto> produtos)
        {
            List<Produto> produtosCopia = new List<Produto>();
            foreach (Produto p in produtos)
            {
                produtosCopia.Add(new Produto(p.Codigo, p.Descricao, p.Marca, p.Preco));
            }
            return produtosCopia;
        }
        static void ListarProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Marca: {produto.Marca}");
                Console.WriteLine($"Preço: {produto.Preco}");
            }
        }
        //preencher uma lista usando função e retornando os valores (lista de produtos)
        static List<Produto> PopularListaDeProdutosRetornando(List<Produto> produtos)
        {
            //caso a lista não esteja inicializada.
            if (produtos is null)
                produtos = new List<Produto>();
            //pegar entradas do usuário:
            Console.WriteLine("Insira o código do produto");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a descrição do produto");
            string desc = Console.ReadLine();
            Console.WriteLine("Insira a marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Insira o preço");
            double preco = Convert.ToDouble(Console.ReadLine());
            Produto a = new Produto(codigo, desc, marca, preco);
            produtos.Add(a);
            return produtos;
        }
        //preencher uma lista usando procedimento e referência (lista de produtos)
        static void PopularListaDeProdutosRef(List<Produto> produtos)
        {
            //caso a lista esteja não inicializada.
            if (produtos is null)
                produtos = new List<Produto>();
            //pegar entradas do usuário:
            Console.WriteLine("Insira o código do produto");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a descrição do produto");
            string desc = Console.ReadLine();
            Console.WriteLine("Insira a marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Insira o preço");
            double preco = Convert.ToDouble(Console.ReadLine());
            Produto a = new Produto(codigo, desc, marca, preco);
            produtos.Add(a);
        }
        static Produto EncontrarProduto(List<Produto> produtos, int codigo)
        {
            Produto produto = null;
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Codigo == codigo)
                {
                    produto = produtos[i];
                }
            }
            return produto;
        }
        static Cliente EncontrarCliente(List<Cliente> clientes, int codigo)
        {
            Cliente cliente = null;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Codigo != codigo)
                {
                    continue;
                }
                cliente = clientes[i];
            }
            return cliente;
        }
        static Vendedor EncontrarVendedor(List<Vendedor> vendedores, int codigo)
        {
            Vendedor vendedor = null;
            for (int i = 0; i < vendedores.Count; i++)
            {
                if (vendedores[i].Codigo == codigo)
                {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                    vendedor = vendedores[i];
                }
            }
            return vendedor;
        }
        static void Main(string[] args)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Cliente> clientes = new List<Cliente>();
            List<Venda> vendas = new List<Venda>();
            Carrinho carrinho = new Carrinho();
            Venda vendaAtual = new Venda();
            //Cliente atual 
            Cliente clienteAtual = new Cliente();
            //Vendedor atual
            Vendedor vendedorAtual = new Vendedor();
            List<Produto> produtos = new List<Produto>();
            Produto a = new Produto(0, "Picanha a vácuo", "Bestbeef", 120);
            produtos.Add(a);
            produtos.Add(new Produto(1, "Maminha a vácuo", "Bestbeef", 75));
            produtos.Add(new Produto(2, "Contra-filé a vácuo", "Bestbeef", 60));
            produtos.Add(new Produto(3, "Fraldinha a vácuo", "Bestbeef", 65));
            produtos.Add(new Produto(4, "Entrecot a vácuo", "Bestbeef", 80));
            //mostrar os produtos registrados
            ListarProdutos(produtos);
            Console.WriteLine("Insira a descrição do produto");
            int codigoProduto = Convert.ToInt32(Console.ReadLine());
            //usa a função "EncontrarProduto" para buscar um elemento baseado no campo "código" do produto.
            Produto produtoEncontrado = EncontrarProduto(produtos, codigoProduto);

            //preenchendo a lista;
            //PopularListaDeProdutosRef(produtos);
            //produtos = PopularListaDeProdutosRetornando(produtos);
            //usando a classe Produto para preencher a lista;
            produtos = Produto.PreencherProdutos(produtos);

            //maneira mais fácil para passar todos os produtos para o carrinho.
            carrinho.Produtos = produtos;
            carrinho.Produtos = new List<Produto>();
            //maneira mais complicada porém eficaz;
            foreach (Produto p in produtos)
            {
                carrinho.Produtos.Add(new Produto(p.Codigo, p.Descricao, p.Marca, p.Preco));
            }

            int opcao = Convert.ToInt32(Console.ReadLine());
            //if's ou switch's:
            if (opcao == (int)Opcoes.InserirNoCarrinho)
            {
                //pedir pro usuário o código do produto.
                int codigo = Convert.ToInt32(Console.ReadLine());
                Produto pSelecionado = EncontrarProduto(produtos, codigo);
                //criar uma validação e etc.
                if (pSelecionado != null)
                {
                    //carrinho.Produtos.Add(produtoSelecionado);
                    carrinho.Produtos.Add(new Produto(pSelecionado.Codigo, pSelecionado.Descricao,
                                          pSelecionado.Marca, pSelecionado.Preco));
                    Console.WriteLine("Produto adicionado ao carrinho.");
                }
            }
            else if (opcao == (int)Opcoes.CriarVenda)
            {
                //pedir pro usuário o codigo do cliente;
                //pedir pro usuário o cracha do vendedor;
                //para poder criar a venda;
                int codigoCliente = Convert.ToInt32(Console.ReadLine());
                int codigoVendedor = Convert.ToInt32(Console.ReadLine());
                //encontra o cliente
                Cliente cSelecionado = EncontrarCliente(clientes, codigoCliente);
                //encontra o vendedor
                Vendedor vSelecionado = EncontrarVendedor(vendedores, codigoVendedor);

                //precisa achar os dois para poder criar a venda.
                if (cSelecionado != null && vSelecionado != null)
                {
                    vendaAtual.Cliente = cSelecionado;//fazer isso na hora de fechar a venda: new Cliente(cSelecionado.Codigo, cSelecionado.Nome, cSelecionado.Cpf, cSelecionado.Endereco);
                    vendaAtual.Vendedor = vSelecionado;
                    if (carrinho.Produtos != null && carrinho.Produtos.Any())
                    {
                        //pois assim, caso mexa no carrinho, a atualização aparecerá na venda.
                        vendaAtual.Produtos = carrinho.Produtos;
                        //ou pode se fazer usando algum laço de repetição, adicionando novos objetos na lista.
                    }
                }
            }
            else if (opcao == (int)Opcoes.FinalizarVenda)
            {
                //pega os produtos do carrinho e joga na venda para finalizá-la e guardar o histórico dela.
                vendaAtual.Produtos = CopiarProdutosParaOutraLista(carrinho.Produtos);
                vendaAtual.Cliente = new Cliente(clienteAtual.Codigo, clienteAtual.Nome, clienteAtual.Cpf, clienteAtual.Endereco);
                vendaAtual.Vendedor = new Vendedor(vendedorAtual.Codigo, vendedorAtual.Nome, vendedorAtual.CodigoCracha);
                vendaAtual.Finalizada = true;
                vendas.Add(new Venda());
                Console.WriteLine("Venda finalizada.");
            }








            Vendedor vendedor = new Vendedor("Zé ", "2456412");
            Vendedor vendedor1 = new Vendedor("Zé ", "2456412");
            vendedores.Add(vendedor);
            vendedores.Add(vendedor1);

            Cliente cliente = new Cliente("Dirceu", "000000000", "Rua das Dores");
            Cliente cliente1 = new Cliente("Dirceu", "000000000", "Rua das Dores");
            clientes.Add(cliente);
            clientes.Add(cliente1);

            Venda venda = new Venda(cliente, vendedor1);
            venda.Produtos = carrinho.Produtos;
            Console.WriteLine($"Valor total da venda: {venda.ValorTotal}");
            venda.Produtos = carrinho.Produtos;
            venda.Produtos.Add(new Produto(4, "Entrecot a vácuo", "Bestbeef", 80));
            Console.WriteLine($"Valor total da venda: {venda.ValorTotal}");
            venda.Produtos.Add(new Produto(4, "Entrecot a vácuo", "Bestbeef", 80));
            Console.WriteLine($"Valor total da venda: {venda.ValorTotal}");
            //Venda v1 = new Venda(2000, cliente, vendedor);
            //Venda v2 = new Venda(2000, cliente1, vendedor1);

            //Console.WriteLine("Cliente na venda 1 "+v1.Cliente.Nome) ;
            //Console.WriteLine("Cliente na venda 2 "+v2.Cliente.Nome);

            //Console.WriteLine("Vendedor na venda 1 "+v1.Vendedor.Nome);
            //Console.WriteLine("Vendedor na venda 1 "+v2.Vendedor.Nome);

            //Console.WriteLine("Crachá do vendedor na venda 1 " + v1.Vendedor.CodigoCracha);
            //Console.WriteLine("Crachá do vendedor na venda 2 " + v2.Vendedor.CodigoCracha);

        }
    }
}
